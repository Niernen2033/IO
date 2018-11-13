using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using OptimizationGlobals;

namespace DisplayFunction
{
    class DisplayFunction2D
    {
        
        public DisplayFunction2D(System.Windows.Forms.DataVisualization.Charting.Chart chart, string Function_expression)
            {
                this.chart = chart;
                this.Function_expression = Function_expression;
            }
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private string Function_expression;
    

        public void Load(Compartment AxisX, Compartment AxisY)
        {
            List<string> arguments = new List<string>() { "x" };
            Function function = new Function(this.Function_expression, arguments);
            var x_min = Convert.ToInt32(AxisX.Min);
            var x_max = Convert.ToInt32(AxisX.Max);
            var y_min = Convert.ToInt32(AxisY.Min);
            var y_max = Convert.ToInt32(AxisY.Max);

            chart.Titles.Add("Graph for " + this.Function_expression);
            chart.ChartAreas[0].AxisX.Maximum = x_max;
            chart.ChartAreas[0].AxisX.Minimum = x_min;
            chart.ChartAreas[0].AxisY.Maximum = y_max;
            chart.ChartAreas[0].AxisY.Minimum = y_min;
            chart.Series[0].BorderWidth = 3;

            chart.ChartAreas[0].AxisX.Crossing = 0; // <--- These two lines
            chart.ChartAreas[0].AxisY.Crossing = 0;

            chart.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
            for (int i = x_min; i < x_max; i++)
            {
                chart.Series[0].Points.AddXY(i, function.Evaluate(new List<double>() {i}));
                chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            }

        }

        public void Graph(Compartment AxisX, Compartment AxisY)
        {
            List<string> arguments = new List<string>() { "x" };
            Function function = new Function(this.Function_expression, arguments);
            chart.Series[0].Points.Clear();
            var x_min = Convert.ToInt32(AxisX.Min);
            var x_max = Convert.ToInt32(AxisX.Max);
            var y_min = Convert.ToInt32(AxisY.Min);
            var y_max = Convert.ToInt32(AxisY.Max);

            chart.ChartAreas[0].AxisX.Maximum = x_max;
            chart.ChartAreas[0].AxisX.Minimum = x_min;
            chart.ChartAreas[0].AxisY.Maximum = y_max;
            chart.ChartAreas[0].AxisY.Minimum = y_min;
            chart.Series[0].BorderWidth = 3;

            chart.ChartAreas[0].AxisX.Crossing = 0; // <--- These two lines
            chart.ChartAreas[0].AxisY.Crossing = 0;

            chart.ChartAreas[0].CursorX.IsUserEnabled = true;
            chart.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;
            chart.ChartAreas[0].AxisX.ScaleView.Zoomable = true;

            for (int i = x_min; i <= x_max; i++)
            {
                chart.Series[0].Points.AddXY(i, function.Evaluate(new List<double>() { i }));
                chart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            }

            /*Clear.Enabled = true;
            this.textBox1.Enabled = false;
            this.numericUpDown1.Enabled = false;
            this.numericUpDown2.Enabled = false;
            this.numericUpDown3.Enabled = false;
            this.numericUpDown4.Enabled = false;*/
        }

        public void Clear()
        {
            /*Clear.Enabled = false;
            this.textBox1.Enabled = true;
            this.numericUpDown1.Enabled = true;
            this.numericUpDown2.Enabled = true;
            this.numericUpDown3.Enabled = true;
            this.numericUpDown4.Enabled = true;*/
            chart.Series[0].Points.Clear();

            this.chart.Invalidate();
        }



    }
}
