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
        public ParticleSwarmAlgorithm ParticleSwarmAlgorithm { get; private set; }
        public SimulatedAnnealingAlgorithm SimulatedAnnealingAlgorithm { get; private set; }
        public FireflyAlgorithm FireflyAlgorithm { get; private set; }
        public GlowwormAlgorithm GlowwormAlgorithm { get; private set; }

        public HeuristicAlgorithms()
        {
            this.BatAlgorithm = new BatAlgorithm();
            this.ParticleSwarmAlgorithm = new ParticleSwarmAlgorithm();
            this.SimulatedAnnealingAlgorithm = new SimulatedAnnealingAlgorithm();
            this.FireflyAlgorithm = new FireflyAlgorithm();
            this.GlowwormAlgorithm = new GlowwormAlgorithm();
        }
    }
}
