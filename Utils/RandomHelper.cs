using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public static class RandomHelper
    {
        private static Random _random = new Random((int)DateTime.UtcNow.Ticks);

        public static int GetInt(int minValue, int maxValue)
        {
            return _random.Next(minValue, maxValue + 1);
        }

        public static double GetDouble(double min, double max)
        {
            return min + (max - min) * _random.NextDouble();
        }

        public static bool IsEventHappened(double probability)
        {
            return _random.NextDouble() < probability;
        }
    }
}
