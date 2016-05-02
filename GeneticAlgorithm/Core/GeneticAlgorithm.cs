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
            IInitialChromosomeGenerator<TGene> chromosomeGenerator,
            IFitnessFunction<TGene> fitnessFunction,
            ISelectionStrategy<TGene> selectionStrategy,
            ICrossoverStrategy<TGene> crossoverStrategy,
            IMutationStrategy<TGene> mutationStrategy)
        {
            _populationSize = populationSize;                        
            _selectionStrategy = selectionStrategy;

            _initialPopulationGenerator = new InitialPopulationGenerator<TGene>(chromosomeGenerator, fitnessFunction);
            _crossoverManager = new CrossoverManager<TGene>(crossoverStrategy, fitnessFunction);
            _mutationManager = new MutationManager<TGene>(mutationStrategy, fitnessFunction);
        }

        private readonly int _populationSize;                
        private readonly ISelectionStrategy<TGene> _selectionStrategy; 
        private readonly InitialPopulationGenerator<TGene> _initialPopulationGenerator;
        private readonly CrossoverManager<TGene> _crossoverManager;
        private readonly MutationManager<TGene> _mutationManager; 

        private List<Population<TGene>> Populations { get; set; } = new List<Population<TGene>>(); 

        public BestChromosomesKeeper<TGene> Run(
            int bestResultsCount,
            ITerminationFunction<TGene> terminationFunction)
        {
            var bestChromosomesKeeper = new BestChromosomesKeeper<TGene>(bestResultsCount);

            var currentPopulation = _initialPopulationGenerator.GeneratePopulation(_populationSize);
            Populations.Add(currentPopulation);
            bestChromosomesKeeper.Process(currentPopulation);

            while (!terminationFunction.ShouldTerminate(currentPopulation, Populations))
            {                
                var nextPopulation = _selectionStrategy.NextPopulation(currentPopulation);
                _crossoverManager.Perform(nextPopulation);
                _mutationManager.Perform(nextPopulation);
                currentPopulation = nextPopulation;

                Populations.Add(currentPopulation);
                bestChromosomesKeeper.Process(currentPopulation);
            }

            return bestChromosomesKeeper;
        }
    }
}
