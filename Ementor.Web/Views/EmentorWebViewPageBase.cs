using Abp.Web.Mvc.Views;

namespace Ementor.Web.Views
{
    public abstract class EmentorWebViewPageBase : EmentorWebViewPageBase<dynamic>
    {

    }

    public abstract class EmentorWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected EmentorWebViewPageBase()
        {
            LocalizationSourceName = EmentorConsts.LocalizationSourceName;
        }
    }
}