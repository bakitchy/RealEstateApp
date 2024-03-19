using Microsoft.AspNetCore.Mvc;

namespace RealEstate.WEB.ViewComponents.DefaultsLayout
{
    public class _CompaniesComponentsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
