using Application.Common.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Semicolon.Views.User.Components.About
{
    public class UserAboutMeViewComponent : ViewComponent
    {

        private readonly IIdentityService _identityService;
        private readonly ICurrentUserService _currentUserService;

        public UserAboutMeViewComponent(IIdentityService  identityService, ICurrentUserService  currentUserService)
        {
            _identityService = identityService;
            _currentUserService = currentUserService;
        }
   

        public async Task<IViewComponentResult> InvokeAsync()
        {

            var user = await _identityService.GetUser(_currentUserService.UserId);
            return await Task.FromResult((IViewComponentResult)View("UserAboutMeViewComponent", user));
        }
    }
}
