using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using WorkEffect.Website.Data;
using WorkEffect.Website.Types;

namespace WorkEffect.Website.Controllers
{
    public class CmsPagesController : BaseEntityController<CmsPage>
    {
        public override ActionResult Index()
        {
            ViewBag.Parts = Context.Parts.ToList();

            return base.Index();
        }

        public override ActionResult Details(Guid? id)
        {
            var parts = Context.Parts.Where(a => a.CmsPageId == id);
            ViewBag.Parts = parts.ToList();

            return base.Details(id);
        }

        public ActionResult DetailsAddPart(Guid? id)
        {
            ViewBag.PageId = id;
            return Details(id);
        }

        public ActionResult CreatePart([Bind(Exclude = "Deleted,CreatedOn,CreatedById,UpdatedOn,UpdatedById")] CmsPart model)
        {
            model.Id = Guid.NewGuid();
            model.CmsPageId = model.CmsPageId;
            Context.Parts.Add(model);
            Context.SaveChanges();

            return RedirectToAction("Details", "CmsPages", new { id = model.CmsPageId });
        }

        public ActionResult DeletePart(Guid? id, Guid? pageId)
        {
            Context.DeleteById<CmsPart>(id);

            return RedirectToAction("Details", "CmsPages", new { id = pageId });
        }
    }
}
