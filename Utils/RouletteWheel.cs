using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils
{
    public class RouletteWheel<TItem>
    {
        private List<KeyValuePair<TItem, double>> _options = new List<KeyValuePair<TItem, double>>();

        public void AddOption(TItem key, double value)
        {
            _options.Add(new KeyValuePair<TItem, double>(key, value));
        }

        public TItem GetNext()
        {
            var sum = _options.Sum(p => p.Value);
            var number = RandomHelper.GetDouble(0, sum);

            var index = 0;
            while (number > _options[index].Value)
            {
                number -= _options[index].Value;
                index++;
            }

            return _options[index].Key;
        }
    }
}
