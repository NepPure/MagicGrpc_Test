using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MagicGrpc.Web.Startup;
namespace MagicGrpc.Web.Tests
{
    [DependsOn(
        typeof(MagicGrpcWebModule),
        typeof(AbpAspNetCoreTestBaseModule)
        )]
    public class MagicGrpcWebTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MagicGrpcWebTestModule).GetAssembly());
        }
    }
}