using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WorkEffect.Website.Data;
using WorkEffect.Website.Models;

namespace WorkEffect.Website.Controllers
{
    public class BaseEntityController<T> : BaseController where T : BaseEntity, new()
    {
        // GET: 
        public override async Task<ActionResult> Index()
        {
            await base.PopulateViewBag();

            return View(await Context.Set<T>().ToListAsync());
        }

        // GET: 
        public async Task<ActionResult> Details(int? id)
        {
            await base.PopulateViewBag();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var entity = await Context.Set<T>().FindAsync(id);
            if (entity == null)
            {
                return HttpNotFound();
            }
            return View(entity);
        }

        // GET: 
        public async Task<ActionResult> Create()
        {
            await base.PopulateViewBag();
            return View();
        }

        // POST: 
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual async Task<ActionResult> Create(T entity)
        {
            if (ModelState.IsValid)
            {
                Context.Set<T>().Add(entity);
                await Context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(entity);
        }

        // GET: 
        public async Task<ActionResult> Edit(int? id)
        {
            await base.PopulateViewBag();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var entity = await Context.Set<T>().FindAsync(id);
            if (entity == null)
            {
                return HttpNotFound();
            }
            return View(entity);
        }

        // POST: 
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public virtual async Task<ActionResult> Edit(T entity)
        {
            if (ModelState.IsValid)
            {
                Context.Entry(entity).State = EntityState.Modified;
                await Context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(entity);
        }

        // GET: 
        public async Task<ActionResult> Delete(int? id)
        {
            await base.PopulateViewBag();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var entity = await Context.Set<T>().FindAsync(id);
            if (entity == null)
            {
                return HttpNotFound();
            }
            return View(entity);
        }

        // POST:
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            var entity = await Context.Set<T>().FindAsync(id);
            Context.Set<T>().Remove(entity);
            await Context.SaveChangesAsync();
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
    }
}