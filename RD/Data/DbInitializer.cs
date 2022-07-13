﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;

namespace RD.Data
{
    public class DbInitializer
    {
        public static void InitializeDb(IHost host)
        {
            using var scope = host.Services.CreateScope();
            var services = scope.ServiceProvider;
            try
            {
                var dbContext = services.GetRequiredService<TestDbContext>();
                //dbContext.Database.EnsureCreated();
                dbContext.SaveChanges();
            }
            catch (Exception e)
            {
                var logger = services.GetRequiredService<ILogger<Program>>();
                logger.LogError(e, "Error while creating database: ");
            }
        }
    }
}
