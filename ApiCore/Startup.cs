
using ApiCore.Dominio.Repositorio;
using ApiCore.Dominio.Servicios;
using ApiCore.Persistence.Contexto;
using ApiCore.Persistence.Repositorio;
using ApiCore.Servicios;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System;
using System.Text;
using ApiCore.Configuracion;
using ApiCore.Extensions;
using Microsoft.AspNetCore.Http;

namespace ApiCore
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
            services.AddCors();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            // configure strongly typed settings objects
            var appSettingsSection = Configuration.GetSection("AppSettings");
            services.Configure<AppSettings>(appSettingsSection);

            // configure jwt authentication
            var appSettings = appSettingsSection.Get<AppSettings>();
            var key = Encoding.ASCII.GetBytes(appSettings.Secret);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime=true
                };
                x.IncludeErrorDetails = true;                
                x.Events = new JwtBearerEvents()
                {
                    OnAuthenticationFailed = c =>
                    {
                        c.NoResult();
                        c.Response.StatusCode = 401;
                        c.Response.ContentType = "text/plain";
                        return c.Response.WriteAsync(c.Exception.ToString());
                    }

                };

            });
            services.AddDbContextPool<ContribuyenteContexto>( // replace "YourDbContext" with the class name of your DbContext
                 options => options.UseMySql("Server=10.16.216.73;Database=sit;User=mmartinez;Password=Desar2016*;Convert Zero Datetime=True;", // replace with your Connection String
                     mySqlOptions =>
                     {
                         mySqlOptions.ServerVersion(new Version(10, 2,15), ServerType.MariaDb); // replace with your Server Version and Type
                    }
             ));

            

            services.AddScoped<ITodoRucRepository, ContribuyenteRepository>();     
            services.AddScoped<ITodoRucContribuyente, ContribuyenteService>();
            services.AddScoped<IUserService, UserService>();

            services.AddAutoMapper();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }
            //app.UseIdentityServer();
            // AÑADIMOS EL MIDDLEWARE DE AUTENTICACIÓN
            // DE USUARIOS AL PIPELINE DE ASP.NET CORE
            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
