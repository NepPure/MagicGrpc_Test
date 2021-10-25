using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MagicGrpc.Configuration;
using MagicGrpc.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ApplicationParts;
using Microsoft.Extensions.Configuration;

namespace MagicGrpc.Web.Startup
{
    [DependsOn(
        typeof(MagicGrpcApplicationModule), 
        typeof(MagicGrpcEntityFrameworkCoreModule), 
        typeof(AbpAspNetCoreModule))]
    public class MagicGrpcWebModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public MagicGrpcWebModule(IWebHostEnvironment env)
        {
            _appConfiguration = AppConfigurations.Get(env.ContentRootPath, env.EnvironmentName);
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(MagicGrpcConsts.ConnectionStringName);

            Configuration.Navigation.Providers.Add<MagicGrpcNavigationProvider>();

            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(MagicGrpcApplicationModule).GetAssembly()
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MagicGrpcWebModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MagicGrpcWebModule).Assembly);
        }
    }
}
