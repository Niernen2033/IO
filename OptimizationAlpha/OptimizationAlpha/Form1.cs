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
        DisplayFunction2D displayfunction;
        public Form1()
        {
            InitializeComponent();
            this.displayfunction = new DisplayFunction2D(this.chart1,"x*x");
            this.displayfunction.Load(new Compartment(-5, 5), new Compartment(-5, 5));
            this.displayfunction.Graph(new Compartment(-5, 5), new Compartment(-5, 5));
        }
    }
}
