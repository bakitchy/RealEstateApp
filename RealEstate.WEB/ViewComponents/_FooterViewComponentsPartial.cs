using Microsoft.AspNetCore.Mvc;

namespace RealEstate.WEB.ViewComponents
{
    public class _FooterViewComponentsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
