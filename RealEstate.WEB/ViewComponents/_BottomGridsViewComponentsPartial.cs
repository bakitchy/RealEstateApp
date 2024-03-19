using Microsoft.AspNetCore.Mvc;

namespace RealEstate.WEB.ViewComponents.DefaultsLayout
{
    public class _BottomGridsViewComponentsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
