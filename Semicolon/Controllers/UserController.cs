using Application.Common.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    public class UserController: Controller
    {
        private readonly IIdentityService _identityService;

        private readonly ILogger<UserController> _logger;
        public UserController(ILogger<UserController> logger, IIdentityService identityService)
        {
            _logger = logger;
            _identityService = identityService;
        }
        [Route("{userName}")]
        public async Task<IActionResult> Profile(string userName)
        {

            var user = await _identityService.IsUserExistAsync(userName);
            if (!user)
                return RedirectToAction("/home/error404");
            return View();
        }

        [Route("[Action]/{userName}")]
        public async Task<IActionResult> AboutMe(string userName)
        {

            var user = await _identityService.GetUser(userName);
            if (user is null)
                return RedirectToAction("/home/error404");
            return View(user);
        }
    }
}
