using System;
using System.Collections.Generic;
using System.Text;
using Day1.Resources;

namespace Day2.App
{
    public class PuzzleApp
    {
        private ResourceLoader _resourceLoader;
        public PuzzleApp(ResourceLoader resourceLoader)
        {
            _resourceLoader = resourceLoader;
        }

        public void RunApp()
        {
            var intCodeData = _resourceLoader.CreateIntCodeData();


            Console.WriteLine(intCodeData.OpSections.Count);
            Console.ReadLine();
        }
    }
}
