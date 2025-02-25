using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TorneoDeFutbol.App.Persistencia;

namespace TorneoDeFutbol.App.Frontend
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddSingleton<IRepositorioEquipo, RepositorioEquipo>();
            services.AddSingleton<IRepositorioDirectorTecnico, RepositorioDirectorTecnico>();
            services.AddSingleton<IRepositorioEstadio, RepositorioEstadio>();
            services.AddSingleton<IRepositorioDesempeño, RepositorioDesempeño>();
            services.AddSingleton<IRepositorioMunicipio, RepositorioMunicipio>();
            services.AddSingleton<IRepositorioArbitro, RepositorioArbitro>();
            services.AddSingleton<IRepositorioJugador , RepositorioJugador>();
            services.AddSingleton<IRepositorioPartido , RepositorioPartido>();
            services.AddSingleton<IRepositorioNovedad , RepositorioNovedad>();
            services.AddSingleton<IRepositorioMarcadorFinal , RepositorioMarcadorFinal>();      
            services.AddControllersWithViews();       
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
