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
        public IQueryable<Facility> Facilities => (IQueryable<Facility>)context.Facilities;
    }
}
