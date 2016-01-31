using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using WorkEffect.Website.Data;
using WorkEffect.Website.Models;

namespace WorkEffect.Website.Controllers
{
    public class BaseController : Controller
    {
        public WorkEffectDbContext Context => new WorkEffectDbContext();

        public virtual async Task<ActionResult> Index()
        {
            await PopulateViewBag();

            return View();
        }

        internal async Task<int> PopulateViewBag()
        {
            ViewBag.Sections = await Context.Contents.Include(a => a.Section).ToListAsync();

            return 1;
        }
    }
}