using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneticAlgorithm.Exceptions;
using GeneticAlgorithm.Interfaces;
using GeneticAlgorithm.Managers;
using Utils.Logging;

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
            IMutationStrategy<TGene> mutationStrategy,
            IChromosomeValidator<TGene> chromosomeValidator)
        {
            _populationSize = populationSize;                        
            _selectionStrategy = selectionStrategy;

            _initialPopulationGenerator = new InitialPopulationGenerator<TGene>(chromosomeGenerator, fitnessFunction);
            _crossoverManager = new CrossoverManager<TGene>(crossoverStrategy, fitnessFunction);
            _mutationManager = new MutationManager<TGene>(mutationStrategy, fitnessFunction, chromosomeValidator);
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

            Logger.Log("Genetic Algorithm started");

            var currentPopulation = _initialPopulationGenerator.GeneratePopulation(_populationSize);
            Logger.Log("Initial population has been generated");

            Populations.Add(currentPopulation);
            bestChromosomesKeeper.Process(currentPopulation);

            int iterationNumber = 1;

            while (!terminationFunction.ShouldTerminate(currentPopulation, Populations))
            {                
                var nextPopulation = _selectionStrategy.NextPopulation(currentPopulation);
                _crossoverManager.Perform(nextPopulation);
                _mutationManager.Perform(nextPopulation);
                currentPopulation = nextPopulation;

                Populations.Add(currentPopulation);
                bestChromosomesKeeper.Process(currentPopulation);

                Logger.Log($"Iteration #{iterationNumber} is finished");
                iterationNumber++;
            }
            
            Logger.Log("Genetic Algorithm finished");

            return bestChromosomesKeeper;
        }
    }
}
