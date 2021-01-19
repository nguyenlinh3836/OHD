using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OHD.Areas.Identity.Data;
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
            OHDStoreContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<OHDStoreContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Facilities.Any())
            {
                context.Facilities.AddRange(
                    new Facility
                    {
                       FacilityName="Library"
                    });                   
            }
        }
    }
}