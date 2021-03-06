﻿using System.Collections.Generic;
using System.Linq;

namespace TaskLib
{
    public static class Filter1
    {
        public static IEnumerable<string> Filter(List<string> strings)
        {
            return strings.Where(x => x.StartsWith("L")).OrderBy(x => x);
        }
    }
}
