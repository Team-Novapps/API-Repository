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
using Teoguide.Application.Mapper;
using Teoguide.Application.ServiceImpl;
using Teoguide.Domain.Repository;
using Teoguide.Domain.Service;
using Teoguide.Infrastructure.Context;
using Teoguide.Infrastructure.RepositoryImpl;

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
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();

            //service
            services.AddTransient<IUsuarioService, UsuarioService>();

            //mapping
            var mappingConfig = new MapperConfiguration(
                mc => { mc.AddProfile(new MappingProfile()); }
            );

            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);

            //cors
            services.AddCors(options => { options.AddPolicy("All", builder => builder.WithOrigins("*").WithHeaders("*").WithMethods("*")); });

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
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
