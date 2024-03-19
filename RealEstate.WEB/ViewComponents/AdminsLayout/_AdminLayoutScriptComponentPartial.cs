using Microsoft.AspNetCore.Mvc;

namespace RealEstate.WEB.ViewComponents.AdminsLayout
{
    public class _AdminLayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
