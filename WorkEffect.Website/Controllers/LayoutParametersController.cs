using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WorkEffect.Website.Models;

namespace WorkEffect.Website.Controllers
{
    public class LayoutParametersController : BaseCmsEntityControllerAsync<ContentLayoutParameter>
    {
        public ActionResult List(int id)
        {
            ViewBag.LayoutId = id;
            return View(GetList(id));
        }

        public virtual List<ContentLayoutParameter> GetList(int id)
        {
            return Context.LayoutParameters.Where(a => a.ContentLayoutId == id).ToList();
        }

        public override void OnCreate(ContentLayoutParameter model, int parentID)
        {
            model.ContentLayoutId = parentID;
            base.OnCreate(model, parentID);
        }
    }
}
