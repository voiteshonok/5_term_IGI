using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(WEB_VOITESHONOK_953501.Areas.Identity.IdentityHostingStartup))]
namespace WEB_VOITESHONOK_953501.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}