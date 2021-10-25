using Microsoft.EntityFrameworkCore;

namespace MagicGrpc.EntityFrameworkCore
{
    public static class DbContextOptionsConfigurer
    {
        public static void Configure(
            DbContextOptionsBuilder<MagicGrpcDbContext> dbContextOptions, 
            string connectionString
            )
        {
            /* This is the single point to configure DbContextOptions for MagicGrpcDbContext */
            dbContextOptions.UseSqlServer(connectionString);
        }
    }
}
