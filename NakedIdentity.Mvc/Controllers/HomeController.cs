using System.Web.Mvc;

namespace NakedIdentity.Mvc.Controllers
{
    public class HomeController : AppController
    {
        public ActionResult Index()
        {
            //string _nombre = "marcelo";
            //ViewBag.Nombre = _nombre;
            return View();
        }
	}
}