using System;
using System.Linq;

namespace Day1.Calculator
{
    public class FuelCalculator
    {
        public int CalculateFuelRequirement(int[] moduleMass)
        {
            return moduleMass.Sum(Calculate);
        }

        private int Calculate(int moduleMass)
        {
            var fuelCoveringMassAndFuel = 0;
            var fuelCoveringMass = 0;

            fuelCoveringMass = DivideAndRoundDown(moduleMass);
            fuelCoveringMass -= 2;

            fuelCoveringMassAndFuel += fuelCoveringMass + CalculateForFuel(fuelCoveringMass);

            return fuelCoveringMassAndFuel;
        }

        private int CalculateForFuel(int fuel)
        {
            if (DivideAndRoundDown(fuel) <= 0)
            {
                return fuel + 2;
            }

            var newFuelAmount = DivideAndRoundDown(fuel) - 2;

            return newFuelAmount + CalculateForFuel(newFuelAmount);
        }

        private int RoundDown(int number)
        {
            return (int)Math.Round((double)number, MidpointRounding.ToZero);
        }

        private int DivideAndRoundDown(int mass)
        {
            return RoundDown(mass / 3);
        }
    }
}