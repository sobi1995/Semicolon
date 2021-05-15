using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.Controllers
{
    public class HomeController : BaseAdminController
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
      
    }
}
