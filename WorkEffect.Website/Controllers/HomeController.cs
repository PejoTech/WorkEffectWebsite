using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WorkEffect.Website.Data;
using WorkEffect.Website.Models;

namespace WorkEffect.Website.Controllers
{
    public class HomeController : BaseController
    {
        [RequireHttps]
        public override async Task<ActionResult> Index()
        {
            await base.PopulateViewBag();

            return View();
        }
    }
}