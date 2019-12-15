using System;
using System.Collections.Generic;
using System.Text;
using Day2.Resources.Enumerable;
using Day2.Resources.Module;

namespace Day2.Resources.Module
{
    public class OpSection
    {
        public OpCode OpCode;
        public int NumFirst { get; set; }
        public int NumSecond { get; set; }
        public int WritePosition { get; set; }
    }
}
