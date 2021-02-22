using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OHD.Models
{
    public interface IOHDRepository
    {
        IQueryable<Customer> Customers { get; }
        IQueryable<Facility> Facilities { get; }
        IQueryable<Request> Requests { get; }
        IQueryable<Employee> Employees { get; }
    }
}
