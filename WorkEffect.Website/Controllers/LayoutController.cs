using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;
using WorkEffect.Website.Models;

namespace WorkEffect.Website.Controllers
{
    public class LayoutController : BaseEntityController<Layout>
    {
        //// GET: Layout
        //public async Task<ActionResult> Index()
        //{
        //    return System.Web.UI.WebControls.View(await Context.Layouts.ToListAsync());
        //}

        //// GET: Layout/Details/5
        //public async Task<ActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Layout layout = await Context.Layouts.FindAsync(id);
        //    if (layout == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(layout);
        //}

        //// GET: Layout/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Layout/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> Create([Bind(Include = "Id,Name,HtmlContainer")] Layout layout)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Context.Layouts.Add(layout);
        //        await Context.SaveChangesAsync();
        //        return RedirectToAction("Index");
        //    }

        //    return View(layout);
        //}

        //// GET: Layout/Edit/5
        //public async Task<ActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Layout layout = await Context.Layouts.FindAsync(id);
        //    if (layout == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(layout);
        //}

        //// POST: Layout/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> Edit([Bind(Include = "Id,Name,HtmlContainer")] Layout layout)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Context.Entry(layout).State = EntityState.Modified;
        //        await Context.SaveChangesAsync();
        //        return RedirectToAction("Index");
        //    }
        //    return View(layout);
        //}

        //// GET: Layout/Delete/5
        //public async Task<ActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Layout layout = await Context.Layouts.FindAsync(id);
        //    if (layout == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(layout);
        //}

        //// POST: Layout/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> DeleteConfirmed(int id)
        //{
        //    Layout layout = await Context.Layouts.FindAsync(id);
        //    Context.Layouts.Remove(layout);
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
