﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeuristicAlgorithms;

namespace OptimizationGlobals
{
    class Compartment
    {
        public double Min { get; set; }
        public double Max { get; set; }

        public Compartment(double min, double max)
        {
            if(min > max)
            {
                throw new AlgorithmException(AlgorithmExceptionType.BadRanges);
            }
            this.Min = min;
            this.Max = max;
        }

        public Compartment()
        {
            this.Min = 0;
            this.Max = 0;
        }
    }
}
