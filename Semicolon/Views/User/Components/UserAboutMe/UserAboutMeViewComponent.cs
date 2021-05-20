using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semicolon.Views.User.Components.About
{
    public class UserAboutMeViewComponent : ViewComponent
    {
        public UserAboutMeViewComponent()
        {

        }

        public async Task<IViewComponentResult> InvokeAsync()
        {


            return await Task.FromResult((IViewComponentResult)View("UserAboutMeViewComponent"));
        }
    }
}
