using System.IO;
using System.Linq;
using Day1.Resources.Module;

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
                Values = LoadPuzzleInputFromFile()
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
        private string[] LoadPuzzleInputFromFile()
        {
            return File.ReadAllLines(_moduleWeightsFilePath);
        }
    }
}
