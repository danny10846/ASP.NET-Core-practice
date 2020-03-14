using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;

namespace TestWebsite {
    public class Program {
        //Entry point
        public static void Main(string[] args) {
            CreateHostBuilder(args).Build().Run();            
        }
        //Sets up our website manually by giving it the config files and other information 
        //it needs in order to function correctly. Adds envioronment settings and logger
        public static IHostBuilder CreateHostBuilder(string[] args) {

            return Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder => {
                    webBuilder.UseStartup<Startup>();
                });
        }
    }
}
