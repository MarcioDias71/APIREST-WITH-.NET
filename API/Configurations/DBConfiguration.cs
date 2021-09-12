using System;
using System.Collections.Generic;
using System.IO;
using Data;
using dotenv.net;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API.Configurations
{
    public static class DBConfiguration
    {



        public static void AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            var appRoot = Directory.GetCurrentDirectory();
            var path = Path.Combine(appRoot, ".env");

           var envVars =  DotEnv.Fluent()
            .WithExceptions()
            .WithEnvFiles(path)
            .Read();    

           

            Console.WriteLine(envVars["CONNECTION_STRING"]);
            services.AddDbContext<Context>(options => options.UseNpgsql(envVars["CONNECTION_STRING"]));
        }

        public static void UseDatabaseConfiguration(this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.GetRequiredService<IServiceScopeFactory>().CreateScope();
            using var context = serviceScope.ServiceProvider.GetService<Context>();
            context.Database.Migrate();
            context.Database.EnsureCreated();
        }
    }
}