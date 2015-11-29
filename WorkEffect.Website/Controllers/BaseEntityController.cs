using System;
using System.Collections.Generic;
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
    public class BaseEntityController<T> : BaseController where T: BaseEntity, new ()
    {
        public WorkEffectDbContext Context { get; set; }

        public BaseEntityController()
        {
            // TODO: Autofac
            Context = new WorkEffectDbContext();
        }

        // GET: CmsPages
        public override ActionResult Index()
        {
            return View(Context.Set<T>().ToList());
        }

        // GET: CmsPages/Details/5
        public virtual ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var cmsPage = Context.Set<T>().Find(id);
            if (cmsPage == null)
            {
                return HttpNotFound();
            }
            return View(cmsPage);
        }

        // GET: CmsPages/Create
        public virtual ActionResult Create()
        {
            return View();
        }

        // POST: CmsPages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult Create([Bind(Exclude = "Deleted,CreatedOn,CreatedById,UpdatedOn,UpdatedById")] T entity)
        {
            if (ModelState.IsValid)
            {
                entity.Id = Guid.NewGuid();
                Context.Set<T>().Add(entity);
                Context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(entity);
        }

        // GET: CmsPages/Edit/5
        public virtual ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var entity = Context.Set<T>().Find(id);
            if (entity == null)
            {
                return HttpNotFound();
            }
            return View(entity);
        }

        // POST: CmsPages/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual ActionResult Edit([Bind(Exclude = "Deleted,CreatedOn,CreatedById,UpdatedOn,UpdatedById")] T entity)
        {
            if (ModelState.IsValid)
            {
                Context.Entry(entity).State = EntityState.Modified;
                
                Context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(entity);
        }

        // GET: CmsPages/Delete/5
        public virtual ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var cmsPage = Context.Set<T>().Find(id);
            if (cmsPage == null)
            {
                return HttpNotFound();
            }
            return View(cmsPage);
        }

        // POST: CmsPages/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public virtual ActionResult DeleteConfirmed(Guid id)
        {
            var entity = Context.Set<T>().Find(id);
            Context.Set<T>().Remove(entity);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                Context.Dispose();
            }
            base.Dispose(disposing);
        }

        // TODO: Kill the bastard as soon as possible
        private T ResetBaseProperties(T entity)
        {
            var x = Context.Set<T>().First(a => a.Id == entity.Id);

            entity.CreatedById = x.CreatedById;
            entity.CreatedOn = x.CreatedOn;
            entity.UpdatedById = x.UpdatedById;
            entity.UpdatedOn = x.UpdatedOn;

            return x;
        }
    }
}