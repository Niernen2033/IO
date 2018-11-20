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
using ILNumerics.Drawing.Plotting;

namespace OptimizationAlpha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ilPanel1_Load(object sender, EventArgs e)
        {
            ilPanel1.Scene.Add(
            new ILPlotCube(twoDMode: false) {
            new ILSurface((x,y) => {
                return (float)Math.Sin(0.1f * x * x + 0.2f * y * y);
            })
       });
        }
    }
}
