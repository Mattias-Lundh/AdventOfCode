using System;
using System.Collections.Generic;
using System.Text;
using Autofac;
using Day1.App;
using Day1.Resources;

namespace Day1.Dependancy_Injection
{
    public class IocContainerBuilder
    {
        public static IContainer Build()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ResourceFactory>()
                .SingleInstance();

            builder.RegisterType<ResourceLoader>()
                .WithParameter(
                    "moduleWeightsFilePath", 
                    Environment.CurrentDirectory + "/Resources/ModuleWeights.txt")
                .SingleInstance();

            builder.RegisterType<PuzzleApp>()
                .SingleInstance();

            return builder.Build();
        }
        
    }
}
