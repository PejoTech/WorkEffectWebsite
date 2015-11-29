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
        public ActionResult DetailsAddPart(Guid? id)
        {
            // Use on _PartCreate.cshtml
            ViewBag.PageId = id;

            return Details(id);
        }

        public ActionResult CreateContent([Bind(Exclude = "Deleted,CreatedOn,CreatedById,UpdatedOn,UpdatedById")] CmsContent model)
        {
            model.Id = Guid.NewGuid();
            model.CmsPageId = model.CmsPageId;

            Context.Parts.Add(model);
            Context.SaveChanges();

            return RedirectToAction("Details", "CmsPages", new { id = model.CmsPageId });
        }

        public ActionResult DeleteContent(Guid? id, Guid? pageId)
        {
            Context.DeleteById<CmsContent>(id);

            return RedirectToAction("Details", "CmsPages", new { id = pageId });
        }
    }
}