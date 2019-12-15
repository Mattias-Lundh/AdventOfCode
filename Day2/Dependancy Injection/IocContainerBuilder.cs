using System;
using Autofac;
using Day1.Resources;
using Day2.App;

namespace Day2.Dependancy_Injection
{
    public class IocContainerBuilder
    {
        public static IContainer Build()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ResourceLoader>()
                .WithParameter(
                    "intCodeDataFilePath", 
                    Environment.CurrentDirectory + "/Resources/intcodedata.txt")
                .SingleInstance();

            builder.RegisterType<PuzzleApp>()
                .SingleInstance();

            return builder.Build();
        }
    }
}