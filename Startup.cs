using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace NoNodeModulesIntellisense
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // allows us to serve files from the node_modules folder
            app.UseNodeModules();

            app.UseRouting();

            app.UseEndpoints(builder =>
            {
                builder.MapControllerRoute(
                    "default",
                    "{controller}/{action}/{id?}",
                    new {controller = "App", action = "Index"});
            });
        }
    }
}
