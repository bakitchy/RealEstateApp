﻿using Microsoft.AspNetCore.Mvc;

namespace RealEstate.WEB.ViewComponents.DefaultsLayout
{
    public class _NewsViewComponentsPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
