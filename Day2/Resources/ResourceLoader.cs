using System.IO;
using System.Linq;
using Day2.Resources.Module;

namespace Day1.Resources
{
    public class ResourceLoader
    {
        private readonly string _intCodeDataFilePath;
        public ResourceLoader(string intCodeDataFilePath)
        {
            _intCodeDataFilePath = intCodeDataFilePath;
        }

        public IntCodeData CreateIntCodeData()
        {
            var resource = new IntCodeData
            {
                Sequence = LoadIntCodeDataFromFile()
                    .Split(',')
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
        private string LoadIntCodeDataFromFile()
        {

            var a = File.ReadAllText(_intCodeDataFilePath);
            return File.ReadAllText(_intCodeDataFilePath);
        }
    }
}
