using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.IO;

namespace Day1.Resources
{
    public class ResourceLoader
    {
        private readonly string _moduleWeightsFilePath;
        public ResourceLoader(string moduleWeightsFilePath)
        {
            _moduleWeightsFilePath = moduleWeightsFilePath;
        }

        /// <summary>
        /// loads weight data from embedded txt file.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public string[] GetModuleWeights()
        {
            return File.ReadAllLines(_moduleWeightsFilePath);
        }
    }
}
