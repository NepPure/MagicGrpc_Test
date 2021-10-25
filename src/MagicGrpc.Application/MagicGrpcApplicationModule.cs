using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace MagicGrpc
{
    [DependsOn(
        typeof(MagicGrpcCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MagicGrpcApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MagicGrpcApplicationModule).GetAssembly());
        }
    }
}