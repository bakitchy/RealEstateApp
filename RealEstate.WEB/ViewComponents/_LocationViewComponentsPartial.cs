﻿using Microsoft.AspNetCore.Mvc;

namespace RealEstate.WEB.ViewComponents
{
    public class _LocationViewComponentsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
