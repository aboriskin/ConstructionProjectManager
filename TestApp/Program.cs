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

            var generator = new InitialChromosomeGenerator(data.Activities);

            using (var writer = new StreamWriter("chromosome.txt"))
            {
                for (int i = 0; i < 1000; i++)
                {
                    var chromosome = generator.Generate();
                    writer.WriteLine(JsonConvert.SerializeObject(chromosome));
                    writer.WriteLine(Validation(data, chromosome));
                }
                writer.Close();
            }

        }

        static bool Validation(ProblemData data, Chromosome<int> chromosome)
        {
            if (chromosome == null)
            {
                return true;
            }

            var map = data.Activities.ToDictionary(a => a.Id);

            for (int i = 0; i < chromosome.Genes.Count; i++)
            {
                var geneId = chromosome.Genes[i];

                if (map[geneId].PreActivityIds.IsNullOrEmpty())
                {
                    continue;
                }

                foreach (var preActivityId in map[geneId].PreActivityIds)
                {
                    if (chromosome.Genes.IndexOf(preActivityId) > i)
                    {
                        throw new Exception("Error");
                    }
                }
            }

            return true;
        }
    }
}
