using WilpSocialMedia.Common.API;
using WilpSocialMedia.Common.API.Interface;
using WilpSocialMedia.Common.API.Services;
using WilpSocialMedia.Common.Infrastructure;
using WilpSocialMedia.Common.Infrastructure.Interface;
using WilpSocialMedia.Common.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.IO;

namespace WilpSocialMedia.Common
{
    public static class MainBootsraper
    {
        public static void InitBootsraper(this IServiceCollection services)
        {
            services.AddTransient<IDbContextFactory, DbContextFactory>();
            services.AddTransient<IUrlApiFactory, UrlApiFactory>();
            services.AddTransient<IUserApiService, UserApiService>();
            
            RepositoryBootsraper.RegisterServices(services);
        }


        public static void ConfigSwagger(this IServiceCollection services, string description, string xmlPath)
        {
            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc(Global.API.Version, new Info
                {
                    Version = Global.API.Version,
                    Title = "Wilp Social Media",
                    Description = $"Wilp Social Media :: {description}",
                    Contact = new Contact { Name = "Ravikant Kushwaha", Email = "2022mt03534@wilp.bits-pilani.ac.in", Url = "" }
                });
                
                x.IncludeXmlComments(xmlPath);
            });
        }
    }
}
