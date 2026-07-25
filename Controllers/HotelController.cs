using System.Web.Mvc;

namespace Hotelbookingsystem.Controllers
{
    public class HotelController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}