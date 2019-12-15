using System;
using Autofac;
using Day2.App;
using Day2.Dependancy_Injection;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = IocContainerBuilder.Build();

            container.Resolve<PuzzleApp>()
                .RunApp();
        }
    }
}
