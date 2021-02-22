using OHD.Areas.Identity.Data;
using OHD.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OHD.Models
{
    public class EFOHDRepository:IOHDRepository
    {
        private OHDContext context;
        public EFOHDRepository(OHDContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Facility> Facilities => context.Facilities;
        public IQueryable<Request> Requests => context.Requests;
        public IQueryable<Employee> Employees => context.Employees;
        public IQueryable<Customer> Customers => context.Customers;
    }
}
