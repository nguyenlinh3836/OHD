using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OHD.Areas.Identity.Data;
using OHD.Data;

namespace OHD.Controllers
{
  
    public class RequestController : Controller
    {
        private OHDContext context;
        public IActionResult Index()
        {
            return View();
        }
    }
}
