using DryIoc;
using DryIoc.Microsoft.DependencyInjection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.IO;
using RepositoriesER;
using UnitOfWorkDR.API.App_Start;
using UnitOfWorkDR.API.UnitOfWork;
using DataAccessER.Infraestructure;
using GodSharp.Data.Common.DbProvider;
using System.Reflection;
using System.Linq;
using UnitOfWorkDR.API.Filters;
using Microsoft.AspNetCore.Identity;
using UnitOfWorkDR.API.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;
using RepositoriesER.Interfaces;
using RepositoriesER.Repositories;

namespace UnitOfWorkDR
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseCors(builder => builder
                .AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowCredentials()
            );

            app.UseMvc();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddMvc()
                // Enables controllers to be resolved by DryIoc, OTHERWISE resolved by infrastructure
                .AddControllersAsServices();
            services.AddScoped<AuthorizationFilter>();
            services.AddCors();
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            var config = builder.Build();
            DbProviderManager.LoadConfiguration(config);
            services.AddSingleton<IConfiguration>(config);
            // DryIOC            
            var container = new Container().WithDependencyInjectionAdapter(services);
            container.Register<IApplicationContext, ApplicationContext>();
            container.Register<IConnectionFactory, ConnectionFactory>();
            container.Register<IUnitOfWork, UnitOfWork>();
            container.Register<ICuestionario, Repository_Cuestionario>();
            container.Register<IMoneda, Repository_Moneda>();
            var serviceProvider = container.Resolve<IServiceProvider>();
            // Automapper Configuration
            AutoMapperConfiguration.Configure();

            return serviceProvider;
        }
    }
}
