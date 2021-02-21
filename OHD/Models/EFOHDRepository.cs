using OHD.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OHD.Models
{
    public class EFOHDRepository:IOHDRepository
    {
        private OHDStoreContext context;
        public EFOHDRepository(OHDStoreContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Facility> Facilities => context.Facilities;
        public IQueryable<Request> Requests => context.Requests;
        public IQueryable<Employee> Employees => context.Employees;
    }
}
