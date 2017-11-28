using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Openddd.Configuration;
using Openddd.Web;

namespace Openddd.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class OpendddDbContextFactory : IDesignTimeDbContextFactory<OpendddDbContext>
    {
        public OpendddDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<OpendddDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            OpendddDbContextConfigurer.Configure(builder, configuration.GetConnectionString(OpendddConsts.ConnectionStringName));

            return new OpendddDbContext(builder.Options);
        }
    }
}
