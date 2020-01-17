using System;
using LuckyWeb.Areas.Identity.Data;
using LuckyWeb.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(LuckyWeb.Areas.Identity.IdentityHostingStartup))]
namespace LuckyWeb.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<LuckyWebIdentityContext>(options =>
                    options.UseNpgsql(
                        context.Configuration.GetConnectionString("MascotaDBConnectionString")));

                services.AddDefaultIdentity<LuckyWebUser>()
                    .AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<LuckyWebIdentityContext>();
            });
        }
    }
}