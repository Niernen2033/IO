using System;
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

namespace OptimizationAlpha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radioButton_one_var_CheckedChanged(object sender, EventArgs e)
        {
            listBox_variables.Enabled = true;
        }

        private void radioButton_two_var_CheckedChanged(object sender, EventArgs e)
        {
            listBox_variables.Enabled = true;
        }

        private void listBox_variables_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_function.Enabled = true;
            button_search.Enabled = true;
            button_read_from_file.Enabled = true;
            textBox_function.Text = listBox_variables.Items[listBox_variables.SelectedIndex].ToString();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            // CODE FOR SEARCHING MIN/MAX ALGHORITM
        }

        private void button_help_Click(object sender, EventArgs e)
        {
            // DISPLAY HELP
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
    }
}
