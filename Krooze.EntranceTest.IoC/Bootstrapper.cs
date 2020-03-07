using Krooze.EntranceTest.Application.Services;
using Krooze.EntranceTest.WriteHere.Tests.InjectionTests;
using Krooze.EntranceTest.WriteHere.Tests.LogicTests;
using Krooze.EntranceTest.WriteHere.Tests.WebTests;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Krooze.EntranceTest.IoC
{
    public class Bootstrapper
    {
        public static void RegisterServices(IServiceCollection services)
        {
            // Classes 
            services.AddScoped<InjectionTest, InjectionTest>();
            services.AddScoped<SimpleLogicTest, SimpleLogicTest>();
            services.AddScoped<XMLTest, XMLTest>();
            services.AddScoped<WebTest, WebTest>();


            // Services
            services.AddScoped<CruiseService, CruiseService>();
        }
    }
}
