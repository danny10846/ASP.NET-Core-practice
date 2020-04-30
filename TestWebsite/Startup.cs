using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Linq;
using TestWebsite.Data;


namespace TestWebsite {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {

            //Add ApplicationDbContext to DI. Every time we see DbContextOptions<ApplicationDbContext> in a constructor,
            //This will new up an instance of it with the connection string in place
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
            );
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IServiceProvider serviceProvider) {

            //Store instance of the DI Service Provider so our application can access it anywhere
            IoCContainer.Provider = serviceProvider;

            //If else to give different error based on build or release mode. Build will give detailed error output
            if (env.IsDevelopment()) {
                app.UseDeveloperExceptionPage();

            }
            //Else we're routed to Error view page, as long as home controller has an error method
            else {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            //Allows us to route to any static files in wwwroot, /...style.css should show us the css code within style.css as long as this line of code is here.
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            //Everything in our URL, after default gets put through this routing system
            //Pretend https//localhost:5000/... is before our pattern
            app.UseEndpoints(endpoints => {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                //We can create custom endpoints, so if I now do '.../more/hello' in my website url, it will point to Abouts TellMeMore method, 
                //Along with the correct id parameter of 'hello' within the method.
                endpoints.MapControllerRoute(
                    name: "about",
                    pattern: "more/{yo?}",
                    defaults: new { controller = "About", action = "TellMeMore" });
            });
        }
    }
}
