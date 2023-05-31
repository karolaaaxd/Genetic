using AForge.Genetic;
using System;

namespace Equation_resolving_GA.GaClasses
{
    public class Chromosom : ChromosomeBase
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public double Min { get; }

        public double Max { get; }

        private Random _rand = new Random();
        public Chromosom(double minValue, double maxValue)
        {
            Min = minValue;
            Max = maxValue;
            X = _rand.NextDouble() * (Max - Min) + Min;
            Y = _rand.NextDouble() * (Max - Min) + Min;
        }

        private Chromosom(Chromosom chromosome)
        {
            X = chromosome.X;
            Y = chromosome.Y;
            Min = chromosome.Min;
            Max = chromosome.Max;
            fitness = chromosome.Fitness;
        }

        public override IChromosome Clone()
        {
            return new Chromosom(this);
        }

        public override IChromosome CreateNew()
        {
            return new Chromosom(Min, Max);
        }

        public override void Crossover(IChromosome pair)
        {
            double x1 = ((Chromosom)pair).X;
            double y1 = ((Chromosom)pair).Y;

            double alpha = _rand.NextDouble();

            double newX1 = alpha * X + (1 - alpha) * x1;
            double newX2 = alpha * x1 + (1 - alpha) * X;

            double newY1 = alpha * Y + (1 - alpha) * y1;
            double newY2 = alpha * y1 + (1 - alpha) * Y;

            ((Chromosom)pair).X = newX1;
            ((Chromosom)pair).Y = newY1;
            X = newX2;
            Y = newY2;
        }

        public override void Generate()
        {
            MutateCromosome(); 
        }

        public override void Mutate()
        {
            MutateCromosome();
        }

        public void MutateCromosome()
        {
            X = _rand.NextDouble() * (Max - Min) + Min;
            Y = _rand.NextDouble() * (Max - Min) + Min;
        }
    }
}
