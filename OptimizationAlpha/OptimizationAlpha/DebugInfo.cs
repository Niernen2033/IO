using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OptimizationGlobals
{
    static class DebugInfo
    {
        private static bool State = false;

        public static void Show(string info)
        {
            if (State == true)
            {
                MessageBox.Show(info);
            }
        }

        public static void SetState(bool state)
        {
            State = state;
        }
    }
}
