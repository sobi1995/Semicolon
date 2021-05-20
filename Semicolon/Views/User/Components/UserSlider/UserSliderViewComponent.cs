using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semicolon.Views.User.Components.Slider
{
    public class UserSliderViewComponent : ViewComponent
    {
        public UserSliderViewComponent()
        {
        
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
         

            return await Task.FromResult((IViewComponentResult)View("UserSliderViewComponent"));
        }
    }
}
