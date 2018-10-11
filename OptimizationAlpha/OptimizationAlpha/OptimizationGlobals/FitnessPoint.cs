using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizationGlobals
{
    class FitnessPoint
    {
        public double Fitness { get; set; }
        public Vector Axis { get; set; }

        public FitnessPoint()
        {
            this.Axis = new Vector();
            this.Fitness = 0;
        }

        public FitnessPoint(List<double> values, double fitness)
        {
            this.Axis = new Vector(values);
            this.Fitness = fitness;
        }
    }
}
