using Microsoft.AspNetCore.Mvc;

namespace RealEstate.WEB.Controllers
{
    public class DefaultsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
