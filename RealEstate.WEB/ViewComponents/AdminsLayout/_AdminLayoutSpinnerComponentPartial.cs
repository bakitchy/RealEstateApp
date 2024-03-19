using Microsoft.AspNetCore.Mvc;

namespace RealEstate.WEB.ViewComponents.AdminsLayout
{
    public class _AdminLayoutSpinnerComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
