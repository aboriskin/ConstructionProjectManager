﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.ViewModels
{
    public class ResourceViewModel
    {
        public int Id { get; set; }
        public string ResourceName { get; set; }
        public decimal LimitPerDay { get; set; }
    }
}