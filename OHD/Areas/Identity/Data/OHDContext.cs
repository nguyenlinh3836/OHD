using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OHD.Areas.Identity.Data;
using OHD.Models;

namespace OHD.Data
{
    public class OHDContext : IdentityDbContext<OHDUser>
    {
        public OHDContext(DbContextOptions<OHDContext> options)
            : base(options)
        {
        }
       
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<OHDUser>()
                .HasOne(b => b.Customer)
                .WithOne(i => i.OHDUser)
                .HasForeignKey<Customer>(b => b.IdentityID);

            builder.Entity<OHDUser>()
               .HasOne(c => c.Employee)
               .WithOne(j => j.OHDUser)
               .HasForeignKey<Customer>(k => k.IdentityID);

            base.OnModelCreating(builder);      
        }
        
    }
}
