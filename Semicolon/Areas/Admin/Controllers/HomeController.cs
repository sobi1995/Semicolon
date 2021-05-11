using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.Controllers
{
    public class HomeController : BaseAdminController
    {
        public async Task<IActionResult> Test()
        {
            return View();
        }
        public async Task<IActionResult> Tesst()
        {
            return View();
        }
    }
}
