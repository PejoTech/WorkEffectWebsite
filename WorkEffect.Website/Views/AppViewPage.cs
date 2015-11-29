using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WorkEffect.Website.Data;

namespace WorkEffect.Website.Views
{
    public abstract class AppViewPage<TModel> : WebViewPage<TModel>
    {
        protected IIdentity CurrentUser => HttpContext.Current.User.Identity;
        protected WorkEffectDbContext DbContext => new WorkEffectDbContext();
    }

    public abstract class AppViewPage : AppViewPage<dynamic>
    {
    }
}
