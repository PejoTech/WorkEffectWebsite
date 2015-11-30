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
using WorkEffect.Website.Models;

namespace WorkEffect.Website.Views
{
    public abstract class AppViewPage<TModel> : WebViewPage<TModel>
    {
        protected IIdentity CurrentUser => HttpContext.Current.User.Identity;
        protected List<NavigationInfoModel> NavPages => new WorkEffectDbContext().Pages.Where(a => !a.Deleted).Select(a => new NavigationInfoModel { Name = a.Name, Id = a.Id}).ToList();
    }

    public abstract class AppViewPage : AppViewPage<dynamic>
    {
    }
}
