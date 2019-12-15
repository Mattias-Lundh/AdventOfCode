using System.IO;
using System.Linq;

namespace Day1.Resources
{
    public class ResourceLoader
    {
        private readonly string _moduleWeightsFilePath;
        public ResourceLoader(string moduleWeightsFilePath)
        {
            _moduleWeightsFilePath = moduleWeightsFilePath;
        }

        public ModuleWeights CreateModuleWeights()
        {
            var resource = new ModuleWeights
            {
                Values = LoadModuleWeightsFromFile()
                    .Select(row => int.Parse(row))
                    .ToArray()
            };

            return resource;
        }

        /// <summary>
        /// loads weight data from embedded txt file.
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private string[] LoadModuleWeightsFromFile()
        {
            return File.ReadAllLines(_moduleWeightsFilePath);
        }
    }
}
