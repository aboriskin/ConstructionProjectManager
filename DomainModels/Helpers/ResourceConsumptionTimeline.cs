using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using DomainModels.Exceptions;
using DomainModels.Models;

namespace DomainModels.Helpers
{
    public class ResourceConsumptionTimeline
    {
        private const int DurationIncrement = 1000;

        public ResourceConsumptionTimeline(Resource resource)
        {
            _resource = resource;
        }

        private readonly Resource _resource;
        private List<decimal> _timeline = new List<decimal>();

        public int ResourceId
        {
            get { return _resource.Id; }
        }

        public void Consume(DateRange range, decimal amountPerDay)
        {
            if (!range.IsLimited())
            {
                throw new ConstructionProjectManagerException("It should not be possible to consume the resource unlimited amount of time");
            }

            if (amountPerDay == 0)
            {
                return;
            }

            EnsureTimeLineHasEnoughLength(range.EndIndex.Value);

            foreach (var index in range.Enumerate())
            {                         
                if (_timeline[index] < amountPerDay)
                {
                    throw new ConstructionProjectManagerException("There is no enough resource for your needs");
                }

                _timeline[index] -= amountPerDay;
            }
        }

        public bool IsResourceAvailable(int startIndex, int duration, decimal amountPerDay)
        {
            EnsureTimeLineHasEnoughLength(startIndex + duration - 1);

            if (duration == 0 || amountPerDay == 0)
            {
                return true;
            }

            for (int i = 0; i < duration; i++)
            {
                if (_timeline[startIndex + i] < amountPerDay)
                {
                    return false;
                }
            }

            return true;
        }

        private void EnsureTimeLineHasEnoughLength(int endIndex)
        {
            while (_timeline.Count <= endIndex)
            {
                for (int i = 0; i < DurationIncrement; i++)
                {
                    _timeline.Add(_resource.MaxAvailableAmountPerDay);
                }
            }
        }

        public List<decimal> GetTimeline()
        {
            return _timeline;            
        }
    }
}
