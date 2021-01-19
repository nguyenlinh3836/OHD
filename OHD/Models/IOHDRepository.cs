using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OHD.Models
{
    public interface IOHDRepository
    {
        IQueryable<Facility> Facilities { get; }
    }
}
