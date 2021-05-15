using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.User.Controllers
{
    public class HomeController : UserBaseController
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
