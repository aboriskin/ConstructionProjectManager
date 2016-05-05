using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using DomainModels.GeneticAlgorithm;
using DomainModels.Models;
using DomainModels.Models.Constraints;
using GeneticAlgorithm.Core;
using GeneticAlgorithm.Implementations;
using Newtonsoft.Json;
using Utils.Extensions;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProblemData data;
            using (var reader = new StreamReader("data.txt"))
            {
                var str = reader.ReadToEnd();
                data = JsonConvert.DeserializeObject<ProblemData>(str);
            }

            var chromosomeGenerator = new InitialChromosomeGenerator(data.Activities);
            var fitnessFunction = new FitnessFunction(data.Resources, data.Activities);
            var selectionStrategy = new RouletteWheelSelectionStrategy<int>();
            var crossoverStrategy = new OrderedCrossoverStrategy<int>(probability: 0.65);
            var mutationStrategy = new MutationStrategy<int>(probability: 0.01);
            var chromosomeValidator = new ChromosomeValidator(data.Activities);
            var terminationFunction = new TerminationFunction<int>(generationLimit: 300);

            var geneticAlgorithm = new GeneticAlgorithm<int>(
                15,
                chromosomeGenerator,
                fitnessFunction,
                selectionStrategy,
                crossoverStrategy,
                mutationStrategy,
                chromosomeValidator);

            var resultKeeper = geneticAlgorithm.Run(20, terminationFunction);

            using (var writer = new StreamWriter("result.txt"))
            {
                foreach (var bestResultDescription in resultKeeper.GetBestResults())
                {
                    writer.WriteLine("Generation: {0}. {1}", bestResultDescription.Generation, bestResultDescription.Chromosome);
                }
                writer.Close();
            }
        }
    }
}
