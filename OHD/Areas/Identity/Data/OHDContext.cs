﻿using System;
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
            base.OnModelCreating(builder);      
        }

        
    }
}
