using Application.Common.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semicolon.Views.Home.Components.Work
{
    public class WorkViewComponent : ViewComponent
    {
        private readonly IIdentityService _identityService;
        public WorkViewComponent(IIdentityService  identityService)
        {
            _identityService = identityService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var users = await     _identityService.Get5lastUserRegisterOnSite();

            return await Task.FromResult((IViewComponentResult)View("WorkViewComponent",users));

        }
    }
}
