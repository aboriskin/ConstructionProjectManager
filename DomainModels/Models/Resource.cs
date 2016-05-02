﻿namespace DomainModels.Models
{
    public class Resource
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public decimal MaxAvailableAmountPerDay { get; set; }
    }
}
