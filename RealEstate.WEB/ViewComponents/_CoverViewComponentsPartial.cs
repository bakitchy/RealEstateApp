using Microsoft.AspNetCore.Mvc;

namespace RealEstate.WEB.ViewComponents.DefaultsLayout
{
    public class _CoverViewComponentsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
