using Microsoft.AspNetCore.Mvc;

namespace RealEstate.WEB.ViewComponents
{
    public class _ScriptViewComponentsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
