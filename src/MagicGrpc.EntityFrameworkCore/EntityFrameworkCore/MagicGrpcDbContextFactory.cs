using MagicGrpc.Configuration;
using MagicGrpc.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MagicGrpc.EntityFrameworkCore
{
    /* This class is needed to run EF Core PMC commands. Not used anywhere else */
    public class MagicGrpcDbContextFactory : IDesignTimeDbContextFactory<MagicGrpcDbContext>
    {
        public MagicGrpcDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MagicGrpcDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            DbContextOptionsConfigurer.Configure(
                builder,
                configuration.GetConnectionString(MagicGrpcConsts.ConnectionStringName)
            );

            return new MagicGrpcDbContext(builder.Options);
        }
    }
}