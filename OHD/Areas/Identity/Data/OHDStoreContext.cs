using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OHD.Areas.Identity.Data
{
    public class OHDStoreContext: DbContext
    {
        public OHDStoreContext(DbContextOptions<OHDStoreContext> options) : base(options) { }
        public DbSet<Facility> Facilities { get; set; }
    }
}
