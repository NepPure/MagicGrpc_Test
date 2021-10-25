using Abp.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MagicGrpc.EntityFrameworkCore
{
    public class MagicGrpcDbContext : AbpDbContext
    {
        //Add DbSet properties for your entities...

        public MagicGrpcDbContext(DbContextOptions<MagicGrpcDbContext> options) 
            : base(options)
        {

        }
    }
}
