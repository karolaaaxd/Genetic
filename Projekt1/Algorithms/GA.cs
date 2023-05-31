using AForge.Genetic;
using System.Threading.Tasks;

namespace Equation_resolving_GA.GaClasses
{
    internal class GA
    {
        public async Task Start(string equation, int population, int max, float mutation, float crossover, double domaina, double domainb, int selectionMethod, System.Windows.Forms.TextBox textBox, System.Windows.Forms.TextBox textBox2)
        {
            var populati = new Population(population, new Chromosom(domaina, domainb), new Fitness(equation), GetSelectionMethod(selectionMethod));
            populati.MutationRate = mutation;
            populati.CrossoverRate = crossover;

            populati.RunEpoch();

            var bestChromosome = (Chromosom)populati.BestChromosome;
            double bestFitness = bestChromosome.Fitness;
            double bestX = bestChromosome.X;
            double bestY = bestChromosome.Y;

            for (int i = 1; i < max; i++)
            {
                populati.RunEpoch();

                var bch = (Chromosom)populati.BestChromosome;

                if (bch.Fitness > bestFitness)
                {
                    bestFitness = bch.Fitness;
                    bestX = bch.X;
                    bestY = bch.Y;
                }

                textBox.Text = $"Iteration: {i + 1}, X = {bestX}, Y = {bestY}";
                textBox2.Text = $"Best = {1 / bestFitness}";
                await Task.Delay(1);
            }
        }

        private ISelectionMethod GetSelectionMethod(int Method)
        {
            switch (Method)
            {
                case 0:
                    return new RankSelection();
                case 1:
                    return new RouletteWheelSelection();
                case 2:
                    return new EliteSelection();
                default:
                    return new RankSelection();
            }
        }
    }
}
