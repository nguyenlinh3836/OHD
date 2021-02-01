﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using OHD.Areas.Identity.Data;

namespace OHD.Data
{
    public class OHDContext : IdentityDbContext<OHDUser>
    {
        public OHDContext(DbContextOptions<OHDContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
      
        }
    }
}
