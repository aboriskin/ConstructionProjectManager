using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticAlgorithm.Interfaces;
using GeneticAlgorithm.Managers;

namespace GeneticAlgorithm.Core
{
    public class GeneticAlgorithm<TGene>
    {
        public GeneticAlgorithm(
            int populationSize,
            double crossoverProbability,
            double mutationProbability,
            IInitialChromosomeGenerator<TGene> chromosomeGenerator,
            IFitnessFunction<TGene> fitnessFunction,
            ISelectionStrategy<TGene> selectionStrategy)
        {
            _populationSize = populationSize;
            _crossoverProbability = crossoverProbability;
            _mutationProbability = mutationProbability;
            _fitnessFunction = fitnessFunction;
            _selectionStrategy = selectionStrategy;

            _initialPopulationGenerator = new InitialPopulationGenerator<TGene>(chromosomeGenerator, fitnessFunction);
        }

        private readonly int _populationSize;
        private readonly double _crossoverProbability;
        private readonly double _mutationProbability;
        private readonly IFitnessFunction<TGene> _fitnessFunction;
        private readonly ISelectionStrategy<TGene> _selectionStrategy; 
        private readonly InitialPopulationGenerator<TGene> _initialPopulationGenerator;

        private List<Population<TGene>> Populations { get; set; } = new List<Population<TGene>>(); 

        public void Run()
        {
            var currentPopulation = _initialPopulationGenerator.GeneratePopulation(_populationSize);

            Populations.Add(currentPopulation);

            var nextPopulation = _selectionStrategy.NextPopulation(currentPopulation);

        }
    }
}
