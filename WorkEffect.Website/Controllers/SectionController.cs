using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WorkEffect.Website.Controllers;
using WorkEffect.Website.Models;

namespace ControllerGenerator.Controllers
{
    public class SectionController : BaseEntityController<Section>
    {
        //// GET: Section
        //public async Task<ActionResult> Index()
        //{
        //    var sections = Context.Sections.Include(s => s.Layout);
        //    return View(await sections.ToListAsync());
        //}

        //// GET: Section/Details/5
        //public async Task<ActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Section section = await Context.Sections.FindAsync(id);
        //    if (section == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(section);
        //}

        //// GET: Section/Create
        //public ActionResult Create()
        //{
        //    ViewBag.LayoutId = new SelectList(Context.Layouts, "Id", "Name");
        //    return View();
        //}

        //// POST: Section/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> Create([Bind(Include = "Id,Name,Order,Content,Image,LayoutId")] Section section)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Context.Sections.Add(section);
        //        await Context.SaveChangesAsync();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.LayoutId = new SelectList(Context.Layouts, "Id", "Name", section.LayoutId);
        //    return View(section);
        //}

        //// GET: Section/Edit/5
        //public async Task<ActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Section section = await Context.Sections.FindAsync(id);
        //    if (section == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    ViewBag.LayoutId = new SelectList(Context.Layouts, "Id", "Name", section.LayoutId);
        //    return View(section);
        //}

        //// POST: Section/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> Edit([Bind(Include = "Id,Name,Order,Content,Image,LayoutId")] Section section)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Context.Entry(section).State = EntityState.Modified;
        //        await Context.SaveChangesAsync();
        //        return RedirectToAction("Index");
        //    }
        //    ViewBag.LayoutId = new SelectList(Context.Layouts, "Id", "Name", section.LayoutId);
        //    return View(section);
        //}

        //// GET: Section/Delete/5
        //public async Task<ActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Section section = await Context.Sections.FindAsync(id);
        //    if (section == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(section);
        //}

        //// POST: Section/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> DeleteConfirmed(int id)
        //{
        //    Section section = await Context.Sections.FindAsync(id);
        //    Context.Sections.Remove(section);
        //    await Context.SaveChangesAsync();
        //    return RedirectToAction("Index");
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        Context.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}
    }
}
