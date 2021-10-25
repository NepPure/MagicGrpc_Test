using Abp.AspNetCore.Mvc.Views;

namespace MagicGrpc.Web.Views
{
    public abstract class MagicGrpcRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected MagicGrpcRazorPage()
        {
            LocalizationSourceName = MagicGrpcConsts.LocalizationSourceName;
        }
    }
}
