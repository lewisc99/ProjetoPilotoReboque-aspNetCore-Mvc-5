using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProjetoPilotoReboque.Data;
using ProjetoPilotoReboque.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPilotoReboque
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();


            services.AddDbContext<PilotoReboqueContext>(c =>
            {
                c.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));

            });


            //lembre-se para povoar o banco de dados precisa passar abaixo, que a classe para povoar os dados, vai esta ativa em ambiente de execução.

            services.AddScoped<EnviarDados>();
            services.AddScoped<IFormularioRepositorio, FormularioRepositorio>();

        }

    
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,EnviarDados enviarDados)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                enviarDados.Seed();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
