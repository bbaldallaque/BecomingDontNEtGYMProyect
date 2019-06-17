using System;
using GymProyect.Web.Areas.Identity.Data;
using GymProyect.Web.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(GymProyect.Web.Areas.Identity.IdentityHostingStartup))]
namespace GymProyect.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<DataContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DataContextConnection")));

                services.AddDefaultIdentity<ApplicationUser>()
                    .AddEntityFrameworkStores<DataContext>();
            });
        }
    }
}