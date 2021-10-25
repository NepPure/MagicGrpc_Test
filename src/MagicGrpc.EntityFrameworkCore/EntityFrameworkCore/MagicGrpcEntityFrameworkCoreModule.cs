using Abp.EntityFrameworkCore;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace MagicGrpc.EntityFrameworkCore
{
    [DependsOn(
        typeof(MagicGrpcCoreModule), 
        typeof(AbpEntityFrameworkCoreModule))]
    public class MagicGrpcEntityFrameworkCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MagicGrpcEntityFrameworkCoreModule).GetAssembly());
        }
    }
}