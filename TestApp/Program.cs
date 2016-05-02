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
            var fitnessFunction = new FitnessFunction(data.Resources, data.Activities);

            using (var writer = new StreamWriter("chromosome.txt"))
            {
                for (int i = 0; i < 100; i++)
                {
                    var chromosome = generator.Generate();                    

                    if (chromosome == null)
                    {
                        continue;
                    }

                    writer.WriteLine(JsonConvert.SerializeObject(chromosome));

                    bool isValid;
                    var result = fitnessFunction.Calculate(chromosome, out isValid);

                    writer.WriteLine("{0} - {1}", isValid, result);
                }
                writer.Close();
            }

        }        
    }
}
