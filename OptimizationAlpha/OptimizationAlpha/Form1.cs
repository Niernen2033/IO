﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OptimizationGlobals;
using DisplayFunction;
using HeuristicAlgorithms;

namespace OptimizationAlpha
{
    public partial class Form1 : Form
    {
        private AlgorithmType _myAlgorithmType;
        private string _myFunctionExpression;
        private List<string> _myArgumentsSymbol;
        private List<Compartment> _myRanges;
        private Compartment _axisXRange;
        private Compartment _axisYRange;

        public Form1()
        {
            InitializeComponent();
            //disable legend in chart
            myChart.Series[0].IsVisibleInLegend = false;
        }

        private void textBox_function_Text_Click(object sender, EventArgs e)
        {
            textBox_function.Text = "";
        }

        private void textBox_function_Leave(object sender, EventArgs e)
        {
            if (textBox_function.Text == "")
            {
                textBox_function.Text = listBox_variables.Items[listBox_variables.SelectedIndex].ToString();
            }
        }

        private void radioButton_one_var_CheckedChanged(object sender, EventArgs e)
        {
            listBox_variables.Enabled = true;
            if (radioButton_one_var.Checked == true)
            {
                _myAlgorithmType = AlgorithmType.Minimum;
            }
        }

        private void radioButton_two_var_CheckedChanged(object sender, EventArgs e)
        {
            listBox_variables.Enabled = true;
            if (radioButton_two_var.Checked == true)
            {
                _myAlgorithmType = AlgorithmType.Maximum;
            }
        }

        private void listBox_variables_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_function.Enabled = true;
            button_search.Enabled = true;
            button_read_from_file.Enabled = true;
            textBox_function.Text = listBox_variables.Items[listBox_variables.SelectedIndex].ToString();
        }

        private async void button_search_Click(object sender, EventArgs e)
        {
            // CODE FOR SEARCHING MIN/MAX ALGHORITM
            // clear listbox results
            listBox_results.Items.Clear();

            HeuristicAlgorithms myHeuristicAlgorithms = new HeuristicAlgorithms();
            // best point
            FitnessPoint myFitnessPoint = new FitnessPoint();
            // list of points
            List<FitnessPoint> myListOfFitnessPoints = new List<FitnessPoint>();

            // assign function expresion to variable
            _myFunctionExpression = textBox_function.Text;

            // create list of argument symbols
            AssignArgumentSymbols();

            // create list of ranges for each variable
            _myRanges = new List<Compartment>();

            // validation range of each variable
            switch (_myArgumentsSymbol.Count)
            {
                case 1:
                    {
                        ValidateRangeValues(textBox_X_range_from, textBox_X_range_to);
                        break;
                    }
                case 2:
                    {
                        ValidateRangeValues(textBox_X_range_from, textBox_X_range_to);
                        ValidateRangeValues(textBox_Y_range_from, textBox_Y_range_to);
                        break;
                    }
                case 3:
                    {
                        ValidateRangeValues(textBox_X_range_from, textBox_X_range_to);
                        ValidateRangeValues(textBox_Y_range_from, textBox_Y_range_to);
                        ValidateRangeValues(textBox_Z_range_from, textBox_Z_range_to);
                        break;
                    }
                default:
                    break;
            }

            try
            {
                // find list of fitness points
                myListOfFitnessPoints = await myHeuristicAlgorithms.GetAllOptimalPointsAsync(_myAlgorithmType, _myFunctionExpression, _myArgumentsSymbol, _myRanges);
                // find best fitness point
                myFitnessPoint = await myHeuristicAlgorithms.GetOptimalPointAsync(_myAlgorithmType, _myFunctionExpression, _myArgumentsSymbol, _myRanges);
            }
            catch (AlgorithmException ex)
            {
                switch (ex.Fail)
                {
                    case AlgorithmExceptionType.ParametersNotSeted:
                        AddResult("Parameters no set");
                        break;
                    case AlgorithmExceptionType.FunctionNotExecuted:
                        AddResult("Function not executed");
                        break;
                    case AlgorithmExceptionType.DifferenceArguments:
                        AddResult("Difference arguments");
                        break;
                    case AlgorithmExceptionType.FunctionNotSeted:
                        AddResult("Function no set");
                        break;
                    case AlgorithmExceptionType.WrongParametersArguments:
                        AddResult("Wrong parameters arguments");
                        break;
                    case AlgorithmExceptionType.BadRanges:
                        AddResult("Bad ranges");
                        break;
                }
            }

            foreach (var item in myListOfFitnessPoints)
            {
                AddResult(item.Fitness);
            }

            AddBestResult(myFitnessPoint.Fitness, myFitnessPoint.Axis.Values);

            // display graph for function with 1 variable
            if (_myArgumentsSymbol.Count == 1)
            {
                DisplayFunction2D myDisplayFunction2D = new DisplayFunction2D(myChart, _myFunctionExpression);
                // set axis X range
                _axisXRange = new Compartment(-8, 8);
                // set axis Y range
                _axisYRange = new Compartment(-8, 8);
                // show function graph
                myDisplayFunction2D.Graph(_axisXRange, _axisYRange);
            }
            else if (_myArgumentsSymbol.Count == 2)
            {
                DisplayFunction3D myDisplayFunction3D = new DisplayFunction3D(this.panel_3D, _myFunctionExpression);
                // set axis X range
                _axisXRange = new Compartment(-10, 10);
                // set axis Y range
                _axisYRange = new Compartment(-10, 10);
                // show function graph
                await myDisplayFunction3D.GraphAync(_axisXRange, _axisYRange);
            }
        }

        private void AssignArgumentSymbols()
        {
            // assign argument symbols to variable
            switch (listBox_variables.SelectedIndex)
            {
                case 0:
                    _myArgumentsSymbol = new List<string> { "x" };
                    break;
                case 1:
                    _myArgumentsSymbol = new List<string> { "x", "y" };
                    break;
                case 2:
                    _myArgumentsSymbol = new List<string> { "x", "y", "z" };
                    break;
                default:
                    break;
            }
        }

        private void AddResult(string s)
        {
            listBox_results.Items.Add(s);
        }

        private void AddResult(double val)
        {
            listBox_results.Items.Add($"Result for {_myFunctionExpression}: {Math.Round(val, 2, MidpointRounding.AwayFromZero)}");
        }

        private void AddBestResult(double bestVal, List<double> values)
        {
            string valuesToShow = string.Empty;

            List<string> symbols = new List<string> { "x", "y", "z" };

            for (int i = 0; i < values.Count; i++)
            {
                valuesToShow += symbols[i] + ": " + Math.Round(values[i], 2, MidpointRounding.AwayFromZero).ToString() + " ";
            }

            bestResultLabel.Text = ($"Best result in {Math.Round(bestVal, 2, MidpointRounding.AwayFromZero)} for: {valuesToShow}");
        }

        private void ValidateRangeValues(TextBox textBoxFrom, TextBox textBoxTo)
        {
            int FromValue, ToValue;

            if (textBoxFrom.Text == string.Empty ||
                textBoxTo.Text == string.Empty)
            {
                MessageBox.Show("From value or to value can not be empty. Try again");
                return;
            }

            FromValue = int.Parse(textBoxFrom.Text);
            ToValue = int.Parse(textBoxTo.Text);

            if (FromValue >= ToValue)
            {
                MessageBox.Show("From value can not be higher than to value. Try again");
                return;
            }
            else
            {
                _myRanges.Add(new Compartment(FromValue, ToValue));
                return;
            }
        }

        private void button_help_Click(object sender, EventArgs e)
        {
            // DISPLAY HELP
            HelpForm form = new HelpForm();
            form.Show();
        }

        private void tabPage_2d_Click(object sender, EventArgs e)
        {
            // DISPLAY 2d CHART
        }

        private void tabPage_3d_Click(object sender, EventArgs e)
        {
            // DISPLAY 3D CHART
        }

        private void button_read_from_file_Click(object sender, EventArgs e)
        {
            // READ FROM FILE
        }

        private void textBox_range_from_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar)) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            // allow Backspace  
            if (e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            // only allow minus sign at the beginning
            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
                e.Handled = true;
        }

        private void textBox_range_to_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && (!char.IsDigit(e.KeyChar)) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
            // allow Backspace  
            if (e.KeyChar == (char)8)
            {
                e.Handled = false;
            }
            // only allow minus sign at the beginning
            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0)
                e.Handled = true;
        }

        private void textBox_function_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
