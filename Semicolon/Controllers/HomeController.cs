using Application.Common.Interfaces;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Octokit;
using Octokit.Internal;
using Semicolon.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Semicolon.Controllers
{
    public class HomeController : Controller
    {
        private readonly IIdentityService _identityService;

        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger, IIdentityService identityService)
        {
            _logger = logger;
            _identityService = identityService;
        }
       
        public async Task<IActionResult> Index()
        {
            //if (User.Identity.IsAuthenticated)
            //{
            // var   userName = User.FindFirst(c => c.Type == "urn:github:login")?.Value;
            //    return RedirectToAction("",   userName );
            //}
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View( );
        }

        public IActionResult test()
        {
            return View();
        }

        



        [Route("[controller]/[action]")]
        public async Task<IActionResult> Error404()
        {
           
            return View();
        }
    }
}
