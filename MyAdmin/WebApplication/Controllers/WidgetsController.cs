using System.Web.Mvc;

namespace MyAdmin.Controllers
{
    public class WidgetsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}