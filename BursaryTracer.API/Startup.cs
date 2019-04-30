using AutoMapper;
using BursaryTracer.Data;
using BursaryTracer.Domain;
using BursaryTracer.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BursaryTracer.API
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddDbContext<BTDbContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("BursaryApiDatabase")));

            services.AddScoped<IServicesRepository, ServicesRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<State, StateDTO>().ReverseMap();
                cfg.CreateMap<State, StateWithoutLists>().ReverseMap();
                cfg.CreateMap<StateWithoutLists, StateDTO>().ReverseMap();
                cfg.CreateMap<Governor, GovernorDTO>().ReverseMap();
            });

            app.UseMvc();
        }
    }
}
