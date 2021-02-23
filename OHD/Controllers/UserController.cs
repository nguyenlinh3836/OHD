using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OHD.Areas.Identity.Data;
using OHD.Data;
using OHD.Models;

namespace OHD.Controllers
{
    public class UserController : Controller
    {
        private OHDContext _context;
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddRequest([Bind("RequestId,Time,CustomerID,Detail,FacilityID")] Request request)
        {
            if (ModelState.IsValid)
            {
                request.Time = DateTime.Now;                
                _context.Requests.Add(request);
                _context.SaveChanges();
            }
            return View(request);
        }
       
    }
}
