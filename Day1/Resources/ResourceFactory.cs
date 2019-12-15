using System.Linq;

namespace Day1.Resources
{
    public class ResourceFactory
    {
        private readonly ResourceLoader _resourceLoader;

        public ResourceFactory(ResourceLoader resourceLoader)
        {
            _resourceLoader = resourceLoader;
        }

        public ModuleWeights GenerateResource()
        {
            var resource = new ModuleWeights
            {
                Values = _resourceLoader.GetModuleWeights()
                    .Select(row => int.Parse(row))
                    .ToArray()
            };


            return resource;
        }
    }
}
