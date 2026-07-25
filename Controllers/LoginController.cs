using System.Web.Mvc;

namespace Hotelbookingsystem.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string username, string password)
        {
            if (username == "admin" && password == "123")
            {
                return RedirectToAction("Index", "Hotel");
            }

            ViewBag.Message = "Invalid Username or Password";
            return View();
        }
    }
}