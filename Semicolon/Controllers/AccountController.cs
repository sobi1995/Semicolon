using Infrastructure.Identity;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Controllers
{
    [Route("[controller]/[action]")]
    public class AccountController : Controller
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        public AccountController(SignInManager<ApplicationUser>  signInManager)
        {
            _signInManager = signInManager;
        }
        public async Task<IActionResult> Login()
        {
            return View();
        }

        //public async Task<IActionResult> GithubLogin()
        //{
        //    string redirectUrl = Url.Action("GithubResponse", "Account");
        //    var properties = _signInManager.ConfigureExternalAuthenticationProperties("GithubResponse", redirectUrl);
        //    return new ChallengeResult("GithubResponse", properties);
        //}


        //public async Task<IActionResult> GithubResponse()

        //{
        //    ExternalLoginInfo info = await _signInManager.GetExternalLoginInfoAsync();
        //    if (info == null)
        //        return RedirectToAction(nameof(Login));

        //    var result = await _signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, false, true);


        //    if (result.Succeeded)
        //    {



        //    }
        //    return View();
        //}

        [HttpGet]
        public IActionResult Login(string returnUrl = "/")
        {
            return Challenge(new AuthenticationProperties() { RedirectUri = returnUrl });
        }




    }
}
