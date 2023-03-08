using Microsoft.AspNetCore.Mvc;

namespace MyDeal.TechTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}