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

namespace OptimizationAlpha
{
    public partial class Form1 : Form
    {
        private HeuristicAlgorithms heuristicAlgorithms;
        public Form1()
        {
            InitializeComponent();

            this.heuristicAlgorithms = new HeuristicAlgorithms();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //DebugInfo.SetState(true);
            List<string> arguments = new List<string>() { "x" , "y" };
            Compartment rangeX = new Compartment(-5, 5);
            Compartment rangeY = new Compartment(-5, 5);
            Compartment rangeZ = new Compartment(-5, 5);
            List<Compartment> ranges = new List<Compartment>() { rangeX , rangeY };
            //(Math.Sqrt(x*x)+Math.Sqrt(y*y))*Math.Exp((-0.0625)*(x*x +y*y))
            //-(Math.Sin(x)+y*y+Math.Cos(z))
            string function = "(Math.Sqrt(x*x)+Math.Sqrt(y*y))*Math.Exp((-0.0625)*(x*x +y*y))";
            this.button1.Enabled = false;
            FitnessPoint result = await this.heuristicAlgorithms.GetOptimalPointAsync(AlgorithmType.Maximum, function, arguments, ranges);
            string res = string.Empty;
            for(int i=0; i<result.Axis.Values.Count; i++)
            {
                res += (Math.Round(result.Axis.Values[i], 5, MidpointRounding.AwayFromZero)).ToString() + " | ";
            }
            res += " = " + Math.Round(result.Fitness, 5, MidpointRounding.AwayFromZero);
            this.label1.Text = res;
            this.button1.Enabled = true;
        }
    }
}
