using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OHD.Data;
using OHD.Models;
using OHD.Models.ViewModel;

namespace OHD.Controllers
{
    public class EmployeeController : Controller
    {
        private IOHDRepository repository;
        public EmployeeController(IOHDRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index() => View(repository.Employees);
        public ViewResult ListRequest(int EmployeeId)
            => View(new UserViewModel
            {
                Requests = repository.Requests
                .Where(p=>p.EmployeeID == EmployeeId)
            });
       
    }
}
