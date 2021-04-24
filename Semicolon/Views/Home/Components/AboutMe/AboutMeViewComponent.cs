using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semicolon.Views.Home.Components.About
{
    public class AboutMeViewComponent : ViewComponent
    {
        public AboutMeViewComponent()
        {

        }

        public async Task<IViewComponentResult> InvokeAsync()
        {


            return await Task.FromResult((IViewComponentResult)View("AboutMeViewComponent"));
        }
    }
}
