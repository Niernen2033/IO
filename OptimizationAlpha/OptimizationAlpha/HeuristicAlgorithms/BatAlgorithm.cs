﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using OptimizationGlobals;

namespace HeuristicAlgorithms
{
    class BatAlgorithm : Algorithm
    {
        //Variables====================================================================
        public class Bat : IComparable<Bat>
        {
            public FitnessPoint Position { get; set; }
            public Vector Velocity { get; set; }
            public double Frequency { get; set; }
            public double Audibility { get; set; }
            public double WaveLength { get; set; }
            public double RateOfImpulses { get; set; }

            private LineRandom randomGenerator;

            public Bat(params double[] arguments) : base()
            {
                this.randomGenerator = new LineRandom();

                this.Position = new FitnessPoint(arguments.ToList(), 0);
                this.Velocity = new Vector(arguments.Length);

                this.RateOfImpulses = this.randomGenerator.NextDouble();
                this.Audibility = this.randomGenerator.NextDouble();
                this.WaveLength = 0;
                this.Frequency = 0;
            }

            public Bat(List<double> arguments) : base()
            {
                this.randomGenerator = new LineRandom();

                this.Position = new FitnessPoint(arguments, 0);
                this.Velocity = new Vector(arguments.Count);

                this.RateOfImpulses = this.randomGenerator.NextDouble();
                this.Audibility = this.randomGenerator.NextDouble();
                this.WaveLength = 0;
                this.Frequency = 0;
            }

            public int CompareTo(Bat other)
            {
                if (this.Position.Fitness > other.Position.Fitness)
                    return 1;
                else if (this.Position.Fitness < other.Position.Fitness)
                    return -1;
                else
                    return 0;
            }
        }

        private List<Bat> bats;
        private double alpha;
        private double gamma;
        private Compartment frequency;

        public ReadOnlyCollection<Bat> Bats { get { return this.bats.AsReadOnly(); } }

        //Constructors====================================================================
        public BatAlgorithm(Function function, int batsCount, List<Compartment> ranges) : base(function,batsCount,ranges)
        {
            this.frequency = new Compartment();
            this.alpha = 0.9;
            this.gamma = 0.9;
            this.frequency.Min = 0;
            this.frequency.Max = 10;

            this.bats = new List<Bat>();
            this.CreateAllPoints();
        }

        public BatAlgorithm() : base()
        {
            this.frequency = new Compartment();
            this.alpha = 0.9;
            this.gamma = 0.9;
            this.frequency.Min = 0;
            this.frequency.Max = 10;

            this.bats = new List<Bat>();
        }

        //Functions====================================================================

        private void CreateAllPoints()
        {
            for (int i = 0; i < this.pointsCount; i++)
            {
                List<double> arguments = new List<double>();
                for (int j = 0; j < this.function.ArgumentsSymbol.Count; j++)
                {
                    arguments.Add(this.randomGenerator.NextDouble(this.ranges[j].Min, this.ranges[j].Max));
                }
                this.bats.Add(new Bat(arguments));

                double fitness = 0;
                try
                {
                    fitness = this.function.Evaluate(this.bats[i].Position.Axis.Values);
                }
                catch
                {
                    throw new AlgorithmException(AlgorithmExceptionType.FunctionNotExecuted);
                }
                this.bats[this.bats.Count - 1].Position.Fitness = fitness;
            }
        }

        public override bool NextIteration()
        {
            if(this.function == null)
            {
                throw new AlgorithmException(AlgorithmExceptionType.ParametersNotSeted);
            }

            for (int i = 0; i < this.pointsCount; i++)
            {
                for (int j = 0; j < this.function.ArgumentsSymbol.Count; j++)
                {
                    this.bats[i].Frequency = this.frequency.Min + (this.frequency.Max - this.frequency.Min) * this.randomGenerator.NextDouble();

                    this.bats[i].Velocity.Values[j] = (this.bats[i].Position.Axis.Values[j] - this.bats.Min().Position.Axis.Values[j]) * this.bats[i].Frequency * 0.1;
                    this.bats[i].Position.Axis.Values[j] = this.bats[i].Position.Axis.Values[j] - this.bats[i].Velocity.Values[j];
                }
                double fitness = 0;
                try
                {
                    fitness = this.function.Evaluate(this.bats[i].Position.Axis.Values);
                }
                catch
                {
                    throw new AlgorithmException(AlgorithmExceptionType.FunctionNotExecuted);
                }
                this.bats[i].Position.Fitness = fitness;

                if (this.randomGenerator.NextDouble() < this.bats[i].Audibility)
                {
                    double iterationFitness = 0;
                    double gloabBestFitness = 0;
                    try
                    {
                        iterationFitness = this.function.Evaluate(this.bats[i].Position.Axis.Values);
                    }
                    catch (Exception e)
                    {
                        DebugInfo.Show(e.Message);
                        throw new AlgorithmException(AlgorithmExceptionType.FunctionNotExecuted);
                    }

                    try
                    {
                        gloabBestFitness = this.function.Evaluate(this.bats.Min().Position.Axis.Values);
                    }
                    catch
                    {
                        throw new AlgorithmException(AlgorithmExceptionType.FunctionNotExecuted);
                    }


                    if (iterationFitness < gloabBestFitness)
                    {
                        this.bats[i].RateOfImpulses = this.bats[i].RateOfImpulses * (1 - Math.Exp((-1) * this.gamma * this.acctualIteration));
                        this.bats[i].Audibility = this.alpha * this.bats[i].Audibility;
                    }
                }

            }

            if (this.randomGenerator.NextDouble() > this.bats.Min().RateOfImpulses)
            {
                double sumOfAudibility = 0;
                double averageAudibility;
                for (int i = 0; i < this.pointsCount; i++)
                {
                    sumOfAudibility += this.bats[i].Audibility;
                }
                averageAudibility = sumOfAudibility / this.pointsCount;

                for (int i = 0; i < this.function.ArgumentsSymbol.Count; i++)
                {
                    double random = 0;
                    double helpRandom = this.randomGenerator.NextInt() % 2 + 1;
                    if (helpRandom == 1)
                    {
                        random = (-1) * this.randomGenerator.NextDouble();
                    }
                    else
                    {
                        random = this.randomGenerator.NextDouble();
                    }

                    this.bats.Min().Position.Axis.Values[i] += random * averageAudibility;
                }

                double lastBestFitness = this.bats.Min().Position.Fitness;
                try
                {
                    this.bats.Min().Position.Fitness = this.function.Evaluate(this.bats.Min().Position.Axis.Values);
                }
                catch
                {
                    throw new AlgorithmException(AlgorithmExceptionType.FunctionNotExecuted);
                }

                if (Math.Abs(lastBestFitness - this.bats.Min().Position.Fitness) < 0.01)
                {
                    this.canIEndIterator++;
                    if(this.canIEndIterator == 20)
                    {
                        return false;
                    }
                }
                else
                {
                    this.canIEndIterator = 0;
                }
            }
            if(this.acctualIteration > 200)
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
                this.bats.Clear();
                this.CreateAllPoints();
            }
        }

        public override FitnessPoint GenerateBestValue()
        {
            if(this.function == null)
            {
                throw new AlgorithmException(AlgorithmExceptionType.ParametersNotSeted);
            }

            FitnessPoint result = null;
            while(true)
            {
                if(!this.NextIteration())
                {
                    result = this.bats.Min().Position;
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
                    result = this.bats.Min().Position;
                    break;
                }
            }

            this.Reset();
            return result;
        }
    }
}
