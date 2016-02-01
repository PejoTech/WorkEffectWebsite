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
            ViewBag.Sections = await Context.Sections.ToListAsync();

            return 1;
        }

        public ActionResult RenderContent(Section section)
        {
            return RenderLayout(section.Layout.HtmlContainer, section.Content, section.Name, section.Id, section.Image);
        }

        public ActionResult RenderDummyLayout(Layout layout)
        {
            return RenderLayout(layout.HtmlContainer, "Lorem ipsum dolor sit amet", "Dummy", 0, "dummy.jpg");
        }

        private ActionResult RenderLayout(string html, string content, string sectionName, int sectionId, string image)
        {
            var result = "";
            if (!string.IsNullOrWhiteSpace(image))
            {
                var imagePath = string.Concat("../Content/Images/", image);
                result = string.Format(html, sectionName.Replace(" ", "") + sectionId, imagePath, content);
            }

            return Content(result);
        }
    }
}