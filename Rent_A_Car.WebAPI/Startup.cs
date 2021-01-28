using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Description;
using AutoMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Rent_A_Car.Model.Requests;
using Rent_A_Car.WebAPI.Database;
using Rent_A_Car.WebAPI.Filters;
using Rent_A_Car.WebAPI.Security;
using Rent_A_Car.WebAPI.Services;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.Swagger;
using IDocumentFilter = Swashbuckle.Swagger.IDocumentFilter;

namespace Rent_A_Car.WebAPI
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
            services.AddControllers();
            services.AddMvc(x => x.Filters.Add<ErrorFilter>()).SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            services.AddAutoMapper(typeof(Startup));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
                c.AddSecurityDefinition("basic", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic",
                    In = ParameterLocation.Header,
                    Description = "Basic Authorization header using the Bearer scheme."
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "basic"
                            }
                        },
                        new string[] {}
                    }
                });
            });

            services.AddAuthentication("BasicAuthentication")
                        .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);
     
            services.AddScoped<IZaposlenikService,ZaposlenikService>();
            services.AddScoped<IKlijentService, KlijentService>();

            services.AddScoped<IRezervacijaServicecs, RezervacijaServices>();
            services.AddScoped<ICRUDService<Model.Rezervacija, RezervacijaSearchRequest, RezervacijaUpsertRequest, RezervacijaUpsertRequest>,RezervacijaServices>();

            services.AddScoped<ICRUDService<Model.Vozilo, VoziloSearchRequest, VoziloUpsertRequest, VoziloUpsertRequest>, VoziloService>();
            services.AddScoped<ICRUDService<Model.Ocjena, OcjenaSearchRequest, OcjenaUpsertRequest, OcjenaUpsertRequest>, OcjenaServices>();
            services.AddScoped<ICRUDService<Model.Ugovor, UgovorSearchRequest, UgovorUpsertRequest, UgovorUpsertRequest>, UgovorServices>();
            services.AddScoped<ICRUDService<Model.Grad, GradSearchRequest, GradUpsertRequest, GradUpsertRequest>, GradServices>();


            services.AddScoped<IService<Model.KorisnickiNalog, object>, BaseService<Model.KorisnickiNalog, object, KorisnickiNalog>>();
            //////services.AddScoped<IService<Model.Grad, object>, BaseService<Model.Grad, object, Grad>>();
            services.AddScoped<IService<Model.Kategorija, object>, BaseService<Model.Kategorija, object, Kategorija>>();
            services.AddScoped<IService<Model.Specifikacija, object>, BaseService<Model.Specifikacija, object, Specifikacija>>();
            services.AddScoped<IService<Model.Tip, object>, BaseService<Model.Tip, object, Tip>>();
            services.AddScoped<IService<Model.Drzava, object>, BaseService<Model.Drzava, object, Drzava>>();
            services.AddScoped<IService<Model.Greska, object>, BaseService<Model.Greska, object, Greska>>();
            services.AddScoped<IService<Model.Lokacija, object>, BaseService<Model.Lokacija, object, Lokacija>>();



            var connection = @"Server=.;Database=Rent_A_Car;Trusted_Connection=True;ConnectRetryCount=0";
            services.AddDbContext<Rent_A_CarContext>(options => options.UseSqlServer(connection));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseSwagger();
            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.), 
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
