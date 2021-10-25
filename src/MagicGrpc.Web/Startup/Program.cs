using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace MagicGrpc.Web.Startup
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel(options =>
                options.ConfigureEndpointDefaults(e =>
                e.Protocols = Microsoft.AspNetCore.Server.Kestrel.Core.HttpProtocols.Http2))

                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseStartup<Startup>()
                .UseUrls(new string[] { "http://127.0.0.1:5500" })
                .Build();

            host.Run();
        }
    }
}
