using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels.Helpers
{
    public class DateRange
    {
        public DateRange()
        {            
        }

        public DateRange(int startIndex, int endIndex)
        {
            StartIndex = startIndex;
            EndIndex = endIndex;
        }

        public int? StartIndex { get; set; }
        public int? EndIndex { get; set; }

        public bool IsLimited()
        {
            return StartIndex != null && EndIndex != null;
        }

        public IEnumerable<int> Enumerate()
        {
            var current = StartIndex ?? 0;
            var end = EndIndex ?? int.MaxValue;

            while (current <= end)
            {
                yield return current;
                current++;
            }
        }

        public static DateRange Infinite()
        {
            return new DateRange();
        }
    }
}
