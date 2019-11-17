﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TaskLib
{
    public class Filter
    {
        public Filter()
        {
            Set = new HashSet<int>();
        }

        public HashSet<int> Set { get; private set; }

        public void Filtrate(int num)
        {
            Set.Add(num);
        }

        public object CopyFilter<T>()
        {
            return new Filter { Set = new HashSet<int>(Set) };

            //return this.MemberwiseClone();
        }           

    }
}