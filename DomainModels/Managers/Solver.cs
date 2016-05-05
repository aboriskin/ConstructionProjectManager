using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using DomainModels.Exceptions;
using DomainModels.GeneticAlgorithm;
using DomainModels.Models;
using GeneticAlgorithm.Core;
using GeneticAlgorithm.Implementations;
using GeneticAlgorithm.Managers;
using Utils.Logging;

namespace DomainModels.Managers
{
    public class Solver
    {
        private readonly List<Activity> _activities;
        private readonly List<Resource> _resources;
        private readonly FitnessFunction _fitnessFunction;
        private readonly InitialChromosomeGenerator _chromosomeGenerator;
        private readonly RouletteWheelSelectionStrategy<int> _selectionStrategy;
        private readonly ChromosomeValidator _chromosomeValidator;

        public Solver(
            List<Activity> activities,
            List<Resource> resources)
        {
            _activities = activities;
            _resources = resources;
            _fitnessFunction = new FitnessFunction(_resources, _activities);
            _chromosomeGenerator = new InitialChromosomeGenerator(_activities);
            _selectionStrategy = new RouletteWheelSelectionStrategy<int>();
            _chromosomeValidator = new ChromosomeValidator(_activities);
        }

        public BestChromosomesKeeper<int> Run(
            int populationSize,
            int maxIterations,
            double crossoverProbability,
            double mutationProbability,            
            int resultsToReturn = 1)
        {            
            var crossoverStrategy = new OrderedCrossoverStrategy<int>(crossoverProbability);
            var mutationStrategy = new MutationStrategy<int>(mutationProbability);            
            var terminationFunction = new TerminationFunction<int>(maxIterations);

            var geneticAlgorithm = new GeneticAlgorithm<int>(
                populationSize,
                _chromosomeGenerator,
                _fitnessFunction,
                _selectionStrategy,
                crossoverStrategy,
                mutationStrategy,
                _chromosomeValidator);

            return geneticAlgorithm.Run(resultsToReturn, terminationFunction);
        }

        public double CalculateSchedule(
            Chromosome<int> chromosome)
        {           
            bool isValid;
            var result = _fitnessFunction.Calculate(chromosome, out isValid);

            if (!isValid)
            {
                Logger.Log("Invalid chromosome! " + chromosome.ToString());
                throw new ConstructionProjectManagerException("The final chromosome is not considered as valid. Please look at the log to find out the details");                
            }
            return result;
        }
    }
}
