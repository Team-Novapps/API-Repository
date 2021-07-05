using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Teoguide.Application.Mapper;
using Teoguide.Application.ServiceImpl;
using Teoguide.Domain.Repository;
using Teoguide.Domain.Service;
using Teoguide.Infrastructure.Context;
using Teoguide.Infrastructure.RepositoryImpl;
using Teoguide.Infrastructure.UnitOfWork;

namespace Teoguide.Api
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
            services.AddDbContext<TeoguideDbContext>(
                opts => opts.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
            );
            
            //repository
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<IPlanRepository, PlanRepository>();
            services.AddTransient<IActividadRepository, ActividadRepository>();
            services.AddTransient<ICentroHistoricoRepository, CentroHistoricoRepository>();
            services.AddTransient<IComentarioRespository, ComentarioRespository>();

            //unitofwork
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            //service
            services.AddTransient<IUsuarioService, UsuarioService>();
            services.AddTransient<IPlanService, PlanService>();
            services.AddTransient<ICentroHistoricoService, CentroHistoricoService>();
            services.AddTransient<IComentarioService, ComentarioService>();

            //mapping
            var mappingConfig = new MapperConfiguration(
                mc => { mc.AddProfile(new MappingProfile()); }
            );

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            //cors
            services.AddCors(options => { options.AddPolicy("All", builder => builder.WithOrigins("*").WithHeaders("*").WithMethods("*")); });

            services.AddSwaggerGen(config =>
            {
                config.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "TeoGuide API v1",
                    Description = "servicios api restul para la aplicación web de TeoGuide",
                    Contact = new OpenApiContact()
                    {
                        Name = "TeoGuide",
                        Email = "u201716506@upc.edu.pe",
                        Url = new Uri("https://github.com/Team-Novapps/API-Repository")
                    }
                });                
            });

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseSwagger();

            app.UseSwaggerUI(config =>
            {
                config.SwaggerEndpoint("/swagger/v1/swagger.json", "TeoGuide v1");
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }            

            app.UseCors("All");

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
