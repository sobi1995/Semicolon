using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semicolon.Views.Home.Components.Services
{
    public class ServicesViewComponent : ViewComponent
    {
        public ServicesViewComponent()
        {

        }

        public async Task<IViewComponentResult> InvokeAsync()
        {


            return await Task.FromResult((IViewComponentResult)View("ServicesViewComponent"));
        }
    }
}
