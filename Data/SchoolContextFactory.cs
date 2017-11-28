using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;
using ContosoUniversity.Models;

namespace ContosoUniversity.Data
{
    public class SchoolContextFactory : IDesignTimeDbContextFactory<SchoolContext>
    {
        public SchoolContext CreateDbContext(string[] args)
        {
            return GetContext(EndpointTypes.Writer);
        }

        public SchoolContext CreateDbReaderContext(string[] args)
        {          
            return GetContext(EndpointTypes.Reader);
        }

        public SchoolContext GetContext(EndpointTypes endpointTypes)
        {
            IConfigurationRoot configuration = GetConfiguration();

            var builder = new DbContextOptionsBuilder<SchoolContext>();
            var connectionString = configuration.GetConnectionString(endpointTypes.ToString());
            builder.UseMySql(connectionString);

            return new SchoolContext(builder.Options);
        }

        private IConfigurationRoot GetConfiguration()
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();

            return configuration;
        }
    }
}
