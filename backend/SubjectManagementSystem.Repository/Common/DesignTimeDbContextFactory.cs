using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace SubjectManagementSystem.Repository
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var environmentName = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
            var fileName = Directory.GetCurrentDirectory() + $"/../SubjectManagementSystem.API/appsettings.{environmentName}.json";

            var configuration = new ConfigurationBuilder().AddJsonFile(fileName).Build();
            var connectionString = configuration.GetConnectionString("App");

            var builder = new DbContextOptionsBuilder<ApplicationDbContext>();
            builder.UseNpgsql(connectionString);
            
            return new ApplicationDbContext(builder.Options);
        }
    }
}