using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using technoApi.Interfaces.Services;
using technoApi.Models;
using technoApi.Repositories;
using technoApi.Services;
using technoApi.ViewModels;
using technoApi.ViewModels.Mappings;
using technoApi.ViewModels.Validations;

namespace technoApi
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
            services.AddCors(options =>
            {
                options.AddPolicy("CORS",
                    corsPolicyBuilder => corsPolicyBuilder.AllowAnyOrigin().AllowAnyMethod()
                        .AllowAnyHeader()
                        .AllowCredentials());
            });
            services.AddDbContext<TechnoContext>(options =>
            {
                options.UseMySQL(Configuration["ConnectionStrings:technoConnection"]);
            });
            services.AddScoped<IProfileService, ProfileService>();
            services.AddScoped<IProfileRepository, ProfileRepository>();
            var config = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperConfigurationProfile());
            });

            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);
            services.AddMvc().AddFluentValidation();
            services.AddTransient<IValidator<ProfileViewModel>, ProfileViewModelValidator>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors("CORS");
            app.UseMvc();
        }
    }
}