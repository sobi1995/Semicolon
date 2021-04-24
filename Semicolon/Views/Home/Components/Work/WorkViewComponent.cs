using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semicolon.Views.Home.Components.Work
{
    public class WorkViewComponent : ViewComponent
    {
        public WorkViewComponent()
        {

        }

        public async Task<IViewComponentResult> InvokeAsync()
        {


            return await Task.FromResult((IViewComponentResult)View("WorkViewComponent"));
        }
    }
}
