using System;
using Day1.Calculator;
using Day1.Resources;

namespace Day1.App
{
    public class PuzzleApp
    {
        private readonly ResourceLoader _resourceLoader;
        private readonly FuelCalculator _fuelCalculator;
        public PuzzleApp(
            ResourceLoader resourceFactory,
            FuelCalculator fuelCalculator)
        {
            _resourceLoader = resourceFactory;
            _fuelCalculator = fuelCalculator;
        }

        public void RunApp()
        {
            var resource = _resourceLoader.CreateModuleWeights();

            Console.WriteLine(_fuelCalculator.CalculateFuelRequirement(resource.Values));
            Console.ReadLine();
        }
    }
}
