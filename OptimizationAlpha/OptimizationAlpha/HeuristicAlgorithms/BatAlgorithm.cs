using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using OptimizationGlobals;

namespace HeuristicAlgorithms
{
    class BatAlgorithm : IHeuristicAlgorithm
    {
        public class Bat : IComparable<Bat>
        {
            public Vector Position { get; set; }
            public Vector Velocity { get; set; }
            public double Fitness { get; set; }
            public double Frequency { get; set; }
            public double Audibility { get; set; }
            public double WaveLength { get; set; }
            public double RateOfImpulses { get; set; }

            private LineRandom randomGenerator;
            private bool isWorking;

            public Bat(params double[] arguments) : base()
            {
                this.randomGenerator = new LineRandom();

                this.Position = new Vector(arguments.ToList());
                this.Velocity = new Vector(arguments.Length);
                this.Fitness = 0;

                this.RateOfImpulses = this.randomGenerator.NextDouble();
                this.Audibility = this.randomGenerator.NextDouble();
                this.WaveLength = 0;
                this.Frequency = 0;
            }

            public Bat(List<double> arguments) : base()
            {
                this.randomGenerator = new LineRandom();

                this.Position = new Vector(arguments);
                this.Velocity = new Vector(arguments.Count);
                this.Fitness = 0;

                this.RateOfImpulses = this.randomGenerator.NextDouble();
                this.Audibility = this.randomGenerator.NextDouble();
                this.WaveLength = 0;
                this.Frequency = 0;
            }

            public int CompareTo(Bat other)
            {
                if (this.Fitness > other.Fitness)
                    return 1;
                else if (this.Fitness < other.Fitness)
                    return -1;
                else
                    return 0;
            }
        }

        private List<Bat> bats;
        private Function function;
        private List<Compartment> range;
        private int batsCount;
        private double alpha;
        private double gamma;
        private Compartment frequency;
        private LineRandom randomGenerator;
        private int canIEnditerator;

        public ReadOnlyCollection<Bat> Bats { get { return this.bats.AsReadOnly(); } }
        public int AcctualIteration { get; private set; }

        public BatAlgorithm(Function function, int batsCount, List<Compartment> ranges)
        {
            this.randomGenerator = new LineRandom();
            this.frequency = new Compartment();
            this.range = new List<Compartment>(ranges);
            this.function = function;
            this.batsCount = batsCount;
            this.canIEnditerator = 0;
            this.alpha = 0.9;
            this.gamma = 0.9;
            this.frequency.Min = 0;
            this.frequency.Max = 10;
            this.AcctualIteration = 1;

            this.bats = new List<Bat>();
        }

        public BatAlgorithm()
        {
            this.randomGenerator = new LineRandom();
            this.frequency = new Compartment();
            this.range = new List<Compartment>();
            this.function = null;
            this.batsCount = 0;
            this.canIEnditerator = 0;
            this.alpha = 0.9;
            this.gamma = 0.9;
            this.frequency.Min = 0;
            this.frequency.Max = 10;
            this.AcctualIteration = 1;

            this.bats = new List<Bat>();
        }

        private void CreateAllBats()
        {
            for (int i = 0; i < this.batsCount; i++)
            {
                List<double> arguments = new List<double>();
                for (int j = 0; j < this.function.ArgumentsSymbol.Count; j++)
                {
                    arguments.Add(this.randomGenerator.NextDouble(this.range[j].Min, this.range[j].Max));
                }
                this.bats.Add(new Bat(arguments));

                double fitness = 0;
                try
                {
                    fitness = this.function.Evaluate(this.bats[i].Position.Values);
                }
                catch(Exception e)
                {
                    DebugInfo.Show(e.Message);
                }
                this.bats[this.bats.Count - 1].Fitness = fitness;
            }
        }

        public bool NextIteration(out bool isDone)
        {
            for (int i = 0; i < this.batsCount; i++)
            {
                for (int j = 0; j < this.function.ArgumentsSymbol.Count; j++)
                {
                    this.bats[i].Frequency = this.frequency.Min + (this.frequency.Max - this.frequency.Min) * this.randomGenerator.NextDouble();

                    this.bats[i].Velocity.Values[j] = (this.bats[i].Position.Values[j] - this.bats.Min().Position.Values[j]) * this.bats[i].Frequency * 0.1;
                    this.bats[i].Position.Values[j] = this.bats[i].Position.Values[j] - this.bats[i].Velocity.Values[j];
                }
                double fitness = 0;
                try
                {
                    fitness = this.function.Evaluate(this.bats[i].Position.Values);
                }
                catch (Exception e)
                {
                    DebugInfo.Show(e.Message);
                    isDone = false;
                    return false;
                }
                this.bats[i].Fitness = fitness;

                if (this.randomGenerator.NextDouble() < this.bats[i].Audibility)
                {
                    double iterationFitness = 0;
                    double gloabBestFitness = 0;
                    try
                    {
                        iterationFitness = this.function.Evaluate(this.bats[i].Position.Values);
                    }
                    catch (Exception e)
                    {
                        DebugInfo.Show(e.Message);
                        isDone = false;
                        return false;
                    }

                    try
                    {
                        gloabBestFitness = this.function.Evaluate(this.bats.Min().Position.Values);
                    }
                    catch (Exception e)
                    {
                        DebugInfo.Show(e.Message);
                        isDone = false;
                        return false;
                    }


                    if (iterationFitness < gloabBestFitness)
                    {
                        this.bats[i].RateOfImpulses = this.bats[i].RateOfImpulses * (1 - Math.Exp((-1) * this.gamma * this.AcctualIteration));
                        this.bats[i].Audibility = this.alpha * this.bats[i].Audibility;
                    }
                }

            }

            if (this.randomGenerator.NextDouble() > this.bats.Min().RateOfImpulses)
            {
                double sumOfAudibility = 0;
                double averageAudibility;
                for (int i = 0; i < this.batsCount; i++)
                {
                    sumOfAudibility += this.bats[i].Audibility;
                }
                averageAudibility = sumOfAudibility / this.batsCount;

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

                    this.bats.Min().Position.Values[i] += random * averageAudibility;
                }

                double lastBestFitness = this.bats.Min().Fitness;
                this.bats.Min().Fitness = this.function.Evaluate(this.bats.Min().Position.Values);

                if (Math.Abs(lastBestFitness - this.bats.Min().Fitness) < 0.01)
                {
                    this.canIEnditerator++;
                    if(this.canIEnditerator == 20)
                    {
                        isDone = true;
                        return true;
                    }
                }
                else
                {
                    this.canIEnditerator = 0;
                }
            }
            if(this.AcctualIteration > (int.MaxValue-5))
            {
                isDone = true;
                return true;
            }
            this.AcctualIteration++;
            isDone = false;
            return true;
        }

        public void DeepReset(Function function, int agentsCount, List<Compartment> ranges)
        {
            this.range = new List<Compartment>(ranges);
            this.function = function;
            this.batsCount = agentsCount;
            this.AcctualIteration = 1;
            this.canIEnditerator = 0;

            this.CreateAllBats();
        }

        public Vector GenerateBestValue()
        {
            Vector result = new Vector(this.function.ArgumentsSymbol.Count);
            while(true)
            {
                bool status;
                if(!this.NextIteration(out status))
                {
                    throw new Exception();
                }
                else
                {
                    if(status)
                    {
                        result = this.bats.Min().Position;
                        break;
                    }
                }
            }

            this.Reset();
            return result;
        }

        public void Reset()
        {
            this.AcctualIteration = 1;
            this.canIEnditerator = 0;

            this.CreateAllBats();
        }

        public void SetParameters(Function function, int agentsCount, List<Compartment> ranges)
        {
            this.function = function;
            this.batsCount = agentsCount;
            this.range = new List<Compartment>(ranges);

            this.CreateAllBats();
        }

        public async Task<Vector> GenerateBestValueAsync()
        {
            Vector result = new Vector(this.function.ArgumentsSymbol.Count);
            while (true)
            {
                bool status = true;
                bool isNotDirty = await Task.Run(() => this.NextIteration(out status));
                if (!isNotDirty)
                {
                    throw new Exception();
                }
                else
                {
                    if (status)
                    {
                        result = this.bats.Min().Position;
                        break;
                    }
                }
            }

            this.Reset();
            return result;
        }
    }
}
