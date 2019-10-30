﻿using GroupApp.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(GroupApp.Areas.Identity.IdentityHostingStartup))]

namespace GroupApp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
                services.AddDbContext<UserIdentityContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("GroupAppDb")));

                services.AddDefaultIdentity<IdentityUser>()
                    .AddEntityFrameworkStores<UserIdentityContext>();
            });
        }
    }
}