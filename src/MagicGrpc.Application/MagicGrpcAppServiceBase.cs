using Abp.Application.Services;

namespace MagicGrpc
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class MagicGrpcAppServiceBase : ApplicationService
    {
        protected MagicGrpcAppServiceBase()
        {
            LocalizationSourceName = MagicGrpcConsts.LocalizationSourceName;
        }
    }
}