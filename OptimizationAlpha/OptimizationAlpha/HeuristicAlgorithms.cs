using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeuristicAlgorithms;

namespace OptimizationAlpha
{
    class HeuristicAlgorithms
    {
        public BatAlgorithm BatAlgorithm { get; private set; }

        public HeuristicAlgorithms()
        {
            this.BatAlgorithm = new BatAlgorithm();
        }
    }
}
