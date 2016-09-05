using System.IO;
using System.Web.Mvc;
using WorkEffect.Website.Data;

namespace WorkEffect.Website.Controllers
{
    public abstract class BaseCmsController : Controller
    {
        public WorkEffectDbContext Context { get; set; }

        protected BaseCmsController()
        {
            Context = new WorkEffectDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                Context.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Called before the action method is invoked.
        /// </summary>
        /// <param name="filterContext">Information about the current request and action.</param>
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
        }


        /// <summary>
        /// Called when an unhandled exception occurs in the action.
        /// </summary>
        /// <param name="filterContext">Information about the current request and action.</param>
        protected override void OnException(ExceptionContext filterContext)
        {
            if (filterContext.Exception is HttpAntiForgeryException && !filterContext.ExceptionHandled)
            {
                filterContext.Result = new RedirectResult("Error");
                filterContext.ExceptionHandled = true;
            }
            else if (filterContext.Exception != null && !filterContext.ExceptionHandled)
            {
                // TODO: Unhandled exceptions
            }
            else
            {
                base.OnException(filterContext);
            }
        }


        /// <summary>
        /// Gets the file stream from request.
        /// </summary>
        /// <returns></returns>
        public Stream GetFileStreamFromRequest()
        {
            if (Request.Files.Count != 0 && Request.Files[0] != null)
            {
                return Request.Files[0].InputStream;
            }
            return Request.InputStream.Length > 0 ? Request.InputStream : null;
        }

        ///// <summary>
        ///// Determines whether the area is allowed for the specified useraccount.
        ///// </summary>
        ///// <param name="useraccount">The useraccount.</param>
        ///// <returns>
        /////   <c>true</c> if [is allowed area] [the specified useraccount]; otherwise, <c>false</c>.
        ///// </returns>
        //protected virtual bool IsAllowedArea(UserAccount useraccount)
        //{
        //    if (useraccount.HasRole(UserRoles.SysAdmin))
        //    {
        //        return true;
        //    }
        //    var eventType = GetCurrentEventType();
        //    return useraccount.Festivals.Any(a => !a.Deleted && a.EventType == eventType);
        //}
    }
}
