using Microsoft.AspNetCore.Mvc;

namespace RealEstate.WEB.ViewComponents
{
    public class _HeadViewComponentsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
