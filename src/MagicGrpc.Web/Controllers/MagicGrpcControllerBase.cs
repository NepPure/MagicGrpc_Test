using Abp.AspNetCore.Mvc.Controllers;

namespace MagicGrpc.Web.Controllers
{
    public abstract class MagicGrpcControllerBase: AbpController
    {
        protected MagicGrpcControllerBase()
        {
            LocalizationSourceName = MagicGrpcConsts.LocalizationSourceName;
        }
    }
}