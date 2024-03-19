using Microsoft.AspNetCore.Mvc;

namespace RealEstate.WEB.ViewComponents.AdminsLayout
{
    public class _AdminLayoutSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
