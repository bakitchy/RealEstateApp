using Microsoft.AspNetCore.Mvc;

namespace RealEstate.WEB.Controllers
{
    public class AdminsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
