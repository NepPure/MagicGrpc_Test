using Abp.Modules;
using Abp.Reflection.Extensions;
using MagicGrpc.Localization;

namespace MagicGrpc
{
    public class MagicGrpcCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            MagicGrpcLocalizationConfigurer.Configure(Configuration.Localization);
            
            Configuration.Settings.SettingEncryptionConfiguration.DefaultPassPhrase = MagicGrpcConsts.DefaultPassPhrase;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MagicGrpcCoreModule).GetAssembly());
        }
    }
}