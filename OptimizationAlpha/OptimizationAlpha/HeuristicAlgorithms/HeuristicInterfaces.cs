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
        bool NextIteration(out bool isDone);
        void DeepReset(Function function, int agentsCount, List<Compartment> ranges);
        void Reset();
        void SetParameters(Function function, int agentsCount, List<Compartment> ranges);
        Vector GenerateBestValue();
        Task<Vector> GenerateBestValueAsync();
    }
}
