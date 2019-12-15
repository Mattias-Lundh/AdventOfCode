using System;
using Day1.Calculator;
using Day1.Resources;

namespace Day1.App
{
    public class PuzzleApp
    {
        private readonly ResourceFactory _resourceFactory;
        private readonly FuelCalculator _fuelCalculator;
        public PuzzleApp(
            ResourceFactory resourceFactory,
            FuelCalculator fuelCalculator)
        {
            _resourceFactory = resourceFactory;
            _fuelCalculator = fuelCalculator;
        }

        public void RunApp()
        {
            var resource = _resourceFactory.GenerateResource();

            Console.WriteLine(_fuelCalculator.CalculateFuelRequirement(resource.ModuleWeights));
            Console.ReadLine();
        }
    }
}
