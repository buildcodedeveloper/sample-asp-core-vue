using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fm.cred.front.mvc.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace fm.cred.front.mvc {
    public class Startup {
        public Startup (IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices (IServiceCollection services) {

            services.AddScoped<IMockConfiguracaoGeralService, ConfiguracaoGeralService> ();
            services.AddScoped<IMockTipoCampoService, TipoCampoService> ();
            services.AddTransient<IBaseService, Soma1Service> ();
            services.AddTransient<IBaseService, Soma2Service> ();

            services.AddScoped<Func<string, IBaseService>> (serviceProvider => key => {
                switch (key) {
                    case "A":
                        return serviceProvider.GetService<Soma1Service> ();
                    case "B":
                        return serviceProvider.GetService<Soma2Service> ();
                    case "C":
                        throw new KeyNotFoundException (); //
                    default:
                        throw new KeyNotFoundException (); // or maybe return null, up to you
                }
            });

            services.Configure<CookiePolicyOptions> (options => {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddMvc ().SetCompatibilityVersion (CompatibilityVersion.Version_2_2)
                .AddJsonOptions (options => {
                    options.SerializerSettings.Formatting = Formatting.Indented;
                    options.SerializerSettings.Converters.Add(new StringEnumConverter());
                });;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure (IApplicationBuilder app, IHostingEnvironment env) {
            if (env.IsDevelopment ()) {
                app.UseDeveloperExceptionPage ();
            } else {
                app.UseExceptionHandler ("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts ();
            }

            app.UseHttpsRedirection ();
            app.UseStaticFiles ();
            app.UseCookiePolicy ();

            app.UseMvc (routes => {
                routes.MapRoute (
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}