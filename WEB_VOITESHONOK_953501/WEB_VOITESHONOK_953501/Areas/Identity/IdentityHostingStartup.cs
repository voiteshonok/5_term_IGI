﻿using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WEB_VOITESHONOK_953501.Data;
using WEB_VOITESHONOK_953501.Entities;

[assembly: HostingStartup(typeof(WEB_VOITESHONOK_953501.Areas.Identity.IdentityHostingStartup))]
namespace WEB_VOITESHONOK_953501.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}