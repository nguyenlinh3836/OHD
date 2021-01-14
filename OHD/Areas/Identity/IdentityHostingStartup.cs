using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OHD.Areas.Identity.Data;
using OHD.Data;

[assembly: HostingStartup(typeof(OHD.Areas.Identity.IdentityHostingStartup))]
namespace OHD.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<OHDContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("OHDContextConnection")));

                services.AddDefaultIdentity<OHDUser>(options => {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                })
                    .AddEntityFrameworkStores<OHDContext>();
            });
        }
    }
}