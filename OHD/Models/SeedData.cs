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
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            OHDContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<OHDContext>();
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
                    },
                    new Facility
                    {
                        FacilityName = "Computer Room"
                    },
                    new Facility
                    {
                        FacilityName = "ClassRoom"
                    },
                    new Facility
                    {
                        FacilityName = "Swimming Pool"
                    },
                    new Facility
                      {
                          FacilityName = "Security"
                      }
                    );
                context.SaveChanges();
            }
        }

    }
}