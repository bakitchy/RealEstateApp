using Microsoft.AspNetCore.Mvc;

namespace RealEstate.WEB.ViewComponents.AdminsLayout
{
    public class _AdminLayoutFooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
