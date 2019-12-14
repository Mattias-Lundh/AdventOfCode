using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Day1.Resources;

namespace Day1.App
{
    public class PuzzleApp
    {
        private readonly ResourceFactory _resourceFactory;
        public PuzzleApp(ResourceFactory resourceFactory)
        {
            _resourceFactory = resourceFactory;
        }

        public void RunApp()
        {
            var resource = _resourceFactory.GenerateResource();

            Console.WriteLine(resource.ModuleWeights.Length);
            Console.ReadLine();
        }
    }
}
