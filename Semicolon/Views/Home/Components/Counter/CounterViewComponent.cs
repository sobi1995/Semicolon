using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semicolon.Views.Home.Components.Counter
{
    public class CounterViewComponent : ViewComponent
    {
        public CounterViewComponent()
        {

        }

        public async Task<IViewComponentResult> InvokeAsync()
        {


            return await Task.FromResult((IViewComponentResult)View("CounterViewComponent"));
        }
    }
}
