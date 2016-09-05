using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WorkEffect.Website.Data;
using WorkEffect.Website.Models;

namespace WorkEffect.Website.Controllers
{
    public class LayoutParametersController : BaseCmsEntityController<ContentLayoutParameter>
    {
        [HttpGet]
        public async Task<ActionResult> ListParameters(int id)
        {
            ViewBag.LayoutId = id;
            return View(await GetList(id));
        }

        public virtual async Task<List<ContentLayoutParameter>> GetList(int id)
        {
            return await Context.LayoutParameters.Where(a => a.ContentLayoutId == id).ToListAsync();
        }

        public override void OnCreate(ContentLayoutParameter model, int parentID)
        {
            model.ContentLayoutId = parentID;
            base.OnCreate(model, parentID);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(false);
        }
    }
}
