using Microsoft.AspNetCore.Mvc;

namespace RealEstate.WEB.ViewComponents
{
    public class _HeaderViewComponentsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
