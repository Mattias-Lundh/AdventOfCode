﻿using Autofac;
using Day1.Dependancy_Injection;
using Day1.App;

namespace Day1
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
