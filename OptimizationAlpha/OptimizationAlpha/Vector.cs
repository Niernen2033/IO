using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptimizationGlobals
{
    public enum StandardAxis { X, Y, Z };

    class Vector
    {
        public readonly List<double> Values;

        public Vector(int size)
        {
            this.Values = new List<double>(size);
            for(int i=0; i<size;i++)
            {
                this.Values[i] = 0;
            }
        }

        public Vector(List<double> values)
        {
            this.Values = new List<double>(values);
        }
    }
}
