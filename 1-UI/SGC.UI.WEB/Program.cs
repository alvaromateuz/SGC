using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SGC.Infrastructure.Data;

namespace SGC.UI.WEB
{
    public class Program
    {       

        public static void Main(string[] args)
        {
            
            var host = CreateWebHostBuilder(args);

            DbContextOptions<ClienteContext> options = new DbContextOptions<ClienteContext>();
            
            DbContextOptionsBuilder<ClienteContext> optBuilder = new DbContextOptionsBuilder<ClienteContext>(options);
            optBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BdSGC;Trusted_Connection=True;MultipleActiveResultSets=true");
            
                var contexto = new ClienteContext(optBuilder.Options);

            DbInitializer.Initialize(contexto);

            host.Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
