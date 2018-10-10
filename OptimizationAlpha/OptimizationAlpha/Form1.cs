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
            List<string> arguments = new List<string>() { "x", "y" };
            Compartment rangeX = new Compartment(-5, 5);
            Compartment rangeY = new Compartment(-5, 5);
            List<Compartment> ranges = new List<Compartment>() { rangeX, rangeY };
            Function function = new Function("-Math.Cos(x)*Math.Cos(x)*Math.Exp(-Math.Pow((x-3.14),2)-Math.Pow((y-3.14),2))", arguments);
            this.heuristicAlgorithms.BatAlgorithm.SetParameters(function, 40, ranges);
            Vector result = await this.heuristicAlgorithms.BatAlgorithm.GenerateBestValueAsync();
            string res = string.Empty;
            for(int i=0; i<result.Values.Count; i++)
            {
                res += (Math.Round(result.Values[i], 5, MidpointRounding.AwayFromZero)).ToString() + " | ";
            }
            this.label1.Text = res;
        }
    }
}
