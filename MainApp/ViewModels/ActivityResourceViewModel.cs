using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModels.Models;

namespace MainApp.ViewModels
{
    public class ActivityResourceViewModel
    {
        public int ResourceId { get; set; }
        public decimal Amount { get; set; }

        public ActivityResourceViewModel Clone()
        {
            return new ActivityResourceViewModel
            {
                ResourceId = this.ResourceId,
                Amount = this.Amount
            };
        }

        public ResourceConsumptionPerDay ConvertToDomain()
        {
            return new ResourceConsumptionPerDay
            {
                ResourceId = this.ResourceId,
                Amount = this.Amount
            };
        }
    }
}
