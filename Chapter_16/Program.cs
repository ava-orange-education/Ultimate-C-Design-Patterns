using Chapter_16._03_Practical_examples_Antipatterns.Web_Example;
using Chapter_16._08_Implementation_Dependency;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }

        //to topic 8 - Implementation Dependency Injection
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IMessageSender, EmailSender>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddSingleton<IConfigurationProvider, ConfigurationProvider>();
        }

    }
}
