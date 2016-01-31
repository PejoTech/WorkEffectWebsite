using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using WorkEffect.Website.Data;

namespace WorkEffect.Website.Controllers
{
    public class BaseController : Controller
    {
        public WorkEffectDbContext Context => new WorkEffectDbContext();

        public BaseController()
        {
            PopulateViewBag();
        }

        private void PopulateViewBag()
        {
            ViewBag.Sections = Context.Sections.ToList();
        }
    }
}