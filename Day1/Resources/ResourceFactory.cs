﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day1.Resources
{
    public class ResourceFactory
    {
        private readonly ResourceLoader _resourceLoader;

        public ResourceFactory(ResourceLoader resourceLoader)
        {
            _resourceLoader = resourceLoader;
        }

        public Resource GenerateResource()
        {
            var resource = new Resource
            {
                ModuleWeights = _resourceLoader.GetModuleWeights()
                    .Select(row => int.Parse(row))
                    .ToArray()
            };


            return resource;
        }
    }
}
