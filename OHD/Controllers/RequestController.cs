using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OHD.Areas.Identity.Data;

namespace OHD.Controllers
{
  
    public class RequestController : Controller
    {
        private OHDStoreContext context;
        public IActionResult Index()
        {
            return View();
        }
    }
}
