using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OptimizationGlobals;

namespace DisplayFunction
{
    class DisplayFunction3D
    {
        private FPanel fPanel;

        public DisplayFunction3D(FPanel fPanel)
        {
            this.fPanel = fPanel;
        }
        public void Load(string function_expression)
        {
            this.fPanel.SetFunction(function_expression);
        }

        public void Graph(Compartment AxisX, Compartment AxisY)
        {
            this.fPanel.ChangeAxisRange(AxisX.Min, AxisX.Max, AxisY.Min, AxisY.Max);
            this.fPanel.Invalidate();
        }

        public void Clear()
        {
            this.fPanel.ClearAll();
        }
    }
}
