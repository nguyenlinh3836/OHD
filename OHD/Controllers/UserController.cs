using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OHD.Models;

namespace OHD.Controllers
{
    public class UserController : Controller
    {
        private IOHDRepository repository;
        public UserController(IOHDRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index() => View(repository.Facilities);

    }
}
