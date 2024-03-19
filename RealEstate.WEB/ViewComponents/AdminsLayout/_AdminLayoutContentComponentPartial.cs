using Microsoft.AspNetCore.Mvc;

namespace RealEstate.WEB.ViewComponents.AdminsLayout
{
    public class _AdminLayoutContentComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
