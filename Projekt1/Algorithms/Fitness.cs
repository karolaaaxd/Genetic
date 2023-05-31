using AForge.Genetic;
using Flee.PublicTypes;
using System;

namespace Equation_resolving_GA.GaClasses
{
    internal class Fitness: IFitnessFunction
    {
        string _equ = string.Empty;

        private double ParseAndExecute(double x, double y)
        {
            ExpressionContext val = new ExpressionContext();
            val.Variables["x"] = x;
            val.Variables["y"] = y;
            var expression = val.CompileDynamic(_equ);
            double result = (double)expression.Evaluate();
            return result;
        }

        public double Evaluate(IChromosome chrom)
        {
            Chromosom eqChromosome = (Chromosom)chrom;
            var res = 1 / Math.Abs(ParseAndExecute(eqChromosome.X, eqChromosome.Y));
            return res;
        }

        public Fitness(string eq)
        {
            _equ = eq;
        }
    }
}
