using System;
using Autofac;
using Day1.App;
using Day1.Calculator;
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

            builder.RegisterType<FuelCalculator>()
                .SingleInstance();

            return builder.Build();
        }
        
    }
}
