using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OHD.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OHD.Models
{
    public class SeedData
    {
        public static void DataDrink(IApplicationBuilder app)
        {
            OHDContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<OHDContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Category.Any())
            {
                context.Category.AddRange(
                  
            }            
                context.SaveChanges();
            }
        }
    }
}