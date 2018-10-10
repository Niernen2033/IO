using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OptimizationGlobals;

namespace HeuristicAlgorithms
{
    interface IHeuristicAlgorithm
    {
        bool StartAlgorithm();
        bool EndAlgorithm();
        bool NextIteration();
        void ResetAlgorithm();
        Vector GenerateBestValue();
    }
}
