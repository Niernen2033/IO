using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OptimizationGlobals;
using System.Collections.ObjectModel;

namespace HeuristicAlgorithms
{
    class ChargedSystemSearchAlgorithm : Algorithm
    {
        //Variables====================================================================
        public class ChargedMolecule : IComparable<ChargedMolecule>
        {
            public FitnessPoint Position { get; set; }
            public Vector Velocity { get; set; }

            private LineRandom randomGenerator;

            public ChargedMolecule(params double[] arguments) : base()
            {
                this.randomGenerator = new LineRandom();

                this.Position = new FitnessPoint(arguments.ToList(), 0);
                this.Velocity = new Vector(arguments.Length);
            }

            public ChargedMolecule(List<double> arguments) : base()
            {
                this.randomGenerator = new LineRandom();

                this.Position = new FitnessPoint(arguments, 0);
                this.Velocity = new Vector(arguments.Count);
            }

            public int CompareTo(ChargedMolecule other)
            {
                if (this.Position.Fitness > other.Position.Fitness)
                    return 1;
                else if (this.Position.Fitness < other.Position.Fitness)
                    return -1;
                else
                    return 0;
            }
        }

        private List<ChargedMolecule> chargedMolecules;

        public ReadOnlyCollection<ChargedMolecule> ChargedMolecules { get { return this.chargedMolecules.AsReadOnly(); } }

        //Constructors====================================================================
        public ChargedSystemSearchAlgorithm(Function function, int particlesCount, List<Compartment> ranges) : base(function, particlesCount, ranges)
        {

            this.chargedMolecules = new List<ChargedMolecule>();
            this.CreateAllPoints();
        }

        public ChargedSystemSearchAlgorithm() : base()
        {

            this.chargedMolecules = new List<ChargedMolecule>();
        }

        //Functions====================================================================
        private void ResetIfOutOffRange(int index)
        {
            for (int j = 0; j < this.ranges.Count; j++)
            {
                if (this.chargedMolecules[index].Position.Axis.Values[j] > this.ranges[j].Max
                    || this.chargedMolecules[index].Position.Axis.Values[j] < this.ranges[j].Min)
                {
                    List<double> arguments = new List<double>();
                    for (int k = 0; k < this.function.ArgumentsSymbol.Count; k++)
                    {
                        arguments.Add(this.randomGenerator.NextDouble(this.ranges[k].Min, this.ranges[k].Max));
                    }
                    this.chargedMolecules[index].Position.Axis.Values = arguments;
                    try
                    {
                        this.chargedMolecules[index].Position.Fitness = this.function.Evaluate(this.chargedMolecules[index].Position.Axis.Values);
                    }
                    catch
                    {
                        throw new AlgorithmException(AlgorithmExceptionType.FunctionNotExecuted);
                    }
                    break;
                }
            }
        }

        private void CreateAllPoints()
        {
            for (int i = 0; i < this.pointsCount; i++)
            {
                List<double> arguments = new List<double>();
                for (int j = 0; j < this.function.ArgumentsSymbol.Count; j++)
                {
                    arguments.Add(this.randomGenerator.NextDouble(this.ranges[j].Min, this.ranges[j].Max));
                }
                this.chargedMolecules.Add(new ChargedMolecule(arguments));

                try
                {
                    this.chargedMolecules[this.chargedMolecules.Count - 1].Position.Fitness = this.function.Evaluate(this.chargedMolecules[i].Position.Axis.Values);
                }
                catch
                {
                    throw new AlgorithmException(AlgorithmExceptionType.FunctionNotExecuted);
                }
            }
        }

        public override bool NextIteration()
        {
            if (this.function == null)
            {
                throw new AlgorithmException(AlgorithmExceptionType.ParametersNotSeted);
            }


            if (this.acctualIteration > 200)
            {
                return false;
            }

            this.acctualIteration++;
            return true;
        }

        public override void SetNewAndReset(Function function, int agentsCount, List<Compartment> ranges)
        {
            this.ranges = new List<Compartment>(ranges);
            this.function = function;
            this.pointsCount = agentsCount;

            this.Reset();
        }

        public override void Reset()
        {
            if (this.function == null)
            {
                throw new AlgorithmException(AlgorithmExceptionType.ParametersNotSeted);
            }
            else
            {
                this.acctualIteration = 1;
                this.canIEndIterator = 0;
                this.chargedMolecules.Clear();
                this.CreateAllPoints();
            }
        }

        public override FitnessPoint GenerateBestValue()
        {
            if (this.function == null)
            {
                throw new AlgorithmException(AlgorithmExceptionType.ParametersNotSeted);
            }

            FitnessPoint result = null;
            while (true)
            {
                if (!this.NextIteration())
                {
                    result = this.chargedMolecules.Min().Position;
                    break;
                }
            }

            this.Reset();
            return result;
        }

        public override async Task<FitnessPoint> GenerateBestValueAsync()
        {
            if (this.function == null)
            {
                throw new AlgorithmException(AlgorithmExceptionType.ParametersNotSeted);
            }

            FitnessPoint result = null;
            while (true)
            {
                bool isNotEnd = await Task.Run(() => this.NextIteration());
                if (!isNotEnd)
                {
                    result = this.chargedMolecules.Min().Position;
                    break;
                }
            }

            this.Reset();
            return result;
        }
    }
}
