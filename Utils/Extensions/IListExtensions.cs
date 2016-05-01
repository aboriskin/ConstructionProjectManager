﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Extensions
{
    public static class IListExtensions
    {
        public static bool IsNullOrEmpty(this IList list)
        {
            return list == null || list.Count == 0;
        }
    }
}
