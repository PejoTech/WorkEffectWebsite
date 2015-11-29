using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using WorkEffect.Website.Data;

namespace WorkEffect.Website.Controllers
{
    public class BaseController : Controller
    {
        public IAuthenticationManager AuthManager => HttpContext.Request.GetOwinContext().Authentication;

        public string UserID => User.Identity.GetUserId();

        public virtual ActionResult Index()
        {
            FetchViewBag();
            return View();
        }

        private void FetchViewBag()
        {
            ViewBag.UserName = AuthManager.User.Identity.Name;
        }
    }
}
