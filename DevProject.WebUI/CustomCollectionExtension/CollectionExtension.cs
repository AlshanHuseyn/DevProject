using DevProject.Business.ValidationRules.FluentValidation;
using DevProject.DataAccess.Concrete.EntityFramework.Context;
using DevProject.DTO.DTOs.DepartmentDtos;
using DevProject.DTO.DTOs.JobDtos;
using DevProject.DTO.DTOs.ReportDtos;
using DevProject.DTO.DTOs.SignDtos;
using DevProject.DTO.DTOs.UserDtos;
using DevProject.Entities.Concrete;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DevProject.WebUI.CustomCollectionExtension
{
    public static class CollectionExtension
    {
        public static void AddCustomIdentity(this IServiceCollection services)
        {
            services.AddIdentity<AppUser, AppRole>(opt =>
                {
                    opt.Password.RequireDigit = false;
                    opt.Password.RequireUppercase = false;
                    opt.Password.RequiredLength = 1;
                    opt.Password.RequireLowercase = false;
                    opt.Password.RequireNonAlphanumeric = false;
                })
                .AddEntityFrameworkStores<DevProjectContext>();
            services.ConfigureApplicationCookie(opt =>
            {
                opt.Cookie.Name = "JobCookie";
                opt.Cookie.SameSite = Microsoft.AspNetCore.Http.SameSiteMode.Strict;
                opt.Cookie.HttpOnly = true;
                opt.ExpireTimeSpan = TimeSpan.FromDays(20);
                opt.Cookie.SecurePolicy = Microsoft.AspNetCore.Http.CookieSecurePolicy.SameAsRequest;
                opt.LoginPath = "/Home/Index";
            });
        }

        public static void AddCustomValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<AddUserDto>, AddUserValidator>();
            services.AddTransient<IValidator<DepartmetAddDto>, DepartmentAddValidator>();
            services.AddTransient<IValidator<DepartmentUpdateDto>, DepartmentUpdateValidator>();
            services.AddTransient<IValidator<JobAddDto>, JobAddValidator>();
            services.AddTransient<IValidator<JobUpdateDto>, JobUpdateValidator>();
            services.AddTransient<IValidator<ReportAddDto>, ReportAddValidator>();
            services.AddTransient<IValidator<ReportUpdateDto>, ReportUpdateValidator>();
            services.AddTransient<IValidator<SignInDto>, SignInValidator>();
            services.AddTransient<IValidator<SignUpDto>, SignUpValidator>();
        }
    }
}
