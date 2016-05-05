using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModels.Models;

namespace MainApp.ViewModels
{
    public class ResourceViewModel
    {
        public int Id { get; set; }
        public string ResourceName { get; set; }
        public decimal LimitPerDay { get; set; }

        public Resource ConvertToDomain()
        {
            return new Resource
            {
                Id = Id,
                Name = ResourceName,
                MaxAvailableAmountPerDay = LimitPerDay
            };
        }
    }
}
