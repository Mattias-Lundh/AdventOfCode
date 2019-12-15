using System;
using System.Collections.Generic;
using System.Linq;
using Day2.Resources.Enumerable;
using MoreLinq;

namespace Day2.Resources.Module
{
    public class IntCodeData
    {
        private int[] _sequence;

        public int[] Sequence
        {
            get { return _sequence; }
            set { _sequence = value; }
        }
    }
}