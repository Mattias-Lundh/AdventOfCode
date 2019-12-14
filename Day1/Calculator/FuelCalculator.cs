using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day1.Calculator
{
    public class FuelCalculator
    {
        public int CalculateFuelRequirement(int[] moduleMass)
        {
            return moduleMass.Sum(CalculateFuelRequirement);
        }

        private int CalculateFuelRequirement(int moduleMass)
        {
            var result = 0;

            result = moduleMass / 3;
            result = (int)Math.Round((double)result, MidpointRounding.ToZero);
            result -= 2;

            return result;
        }
    }
}
