using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Areas.Admin.Controllers
{
  
    [Area("admin")]
    [Route("admin/[controller]/[action]")]
    public class BaseAdminController : Controller
    {
        
    }
}
