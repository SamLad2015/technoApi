using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
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
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ITitleService, TitleService>();
            services.AddScoped<IJobTitleService, JobTitleService>();
            services.AddScoped<IJobTypeService, JobTypeService>();
            services.AddScoped<IAuthService, AuthService>();
            services.AddScoped<IQualificationService, QualificationService>();
            services.AddScoped<IQualificationTypeService, QualificationTypeService>();
            services.AddScoped<IJobHistoryService, JobHistoryService>();
            services.AddScoped<IArticleService, ArticleService>();
            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped<IWidgetService, WidgetService>();
            services.AddScoped<IMenuService, MenuService>();
            
            services.AddScoped<IProfileRepository, ProfileRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ITitleRepository, TitleRepository>();
            services.AddScoped<IJobTitleRepository, JobTitleRepository>();
            services.AddScoped<IJobTypeRepository, JobTypeRepository>();
            services.AddScoped<IQualificationRepository, QualificationRepository>();
            services.AddScoped<IQualificationTypeRepository, QualificationTypeRepository>();
            services.AddScoped<IJobHistoryRepository, JobHistoryRepository>();
            services.AddScoped<IArticleRepository, ArticleRepository>();
            services.AddScoped<ICommentRepository, CommentRepository>();
            services.AddScoped<IWidgetRepository, WidgetRepository>();
            services.AddScoped<IWidgetSizeRepository, WidgetSizeRepository>();
            services.AddScoped<IWidgetClassRepository, WidgetClassRepository>();
            services.AddScoped<IMenuRepository, MenuRepository>();
            
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperConfigurationProfile());
            });

            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);
            services.AddMvc().AddFluentValidation();
            services.AddTransient<IValidator<ProfileViewModel>, ProfileViewModelValidator>();
            services.AddTransient<IValidator<UserViewModel>, UserViewModelValidator>();
            services.AddTransient<IValidator<QualificationViewModel>, QualificationViewModelValidator>();
            services.AddTransient<IValidator<QualificationTypeViewModel>, QualificationTypeViewModelValidator>();
            services.AddTransient<IValidator<JobHistoryViewModel>, JobHistoryViewModelValidator>();
            services.AddTransient<IValidator<JobTypeViewModel>, JobTypeViewModelValidator>();
            services.AddTransient<IValidator<ArticleViewModel>, ArticleViewModelValidator>();
            services.AddTransient<IValidator<CommentViewModel>, CommentViewModelValidator>();
            services.AddTransient<IValidator<WidgetTreeViewModel>, WidgetTreeViewModelValidator>();
            services.AddTransient<IValidator<WidgetListViewModel>, WidgetListViewModelValidator>();
            services.AddTransient<IValidator<MenuViewModel>, MenuViewModelValidator>();
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