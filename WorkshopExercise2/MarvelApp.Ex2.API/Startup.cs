﻿using System;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using MarvelApp.Ex2.CQRS.Autofac;
using MarvelApp.Ex2.DataAccess;
using MarvelApp.Ex2.DataAccess.Autofac;
using MarvelApp.Ex2.DomainServices.Autofac;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MarvelApp.Ex2.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            var builder = new ContainerBuilder();
            builder.RegisterType<MarvelContext>().SingleInstance();

            builder.RegisterModule<RepositoryModule>();
            builder.RegisterModule<DomainServicesModule>();
            builder.RegisterModule<CqrsModule>();

            builder.Populate(services);
            var container = builder.Build();

            return new AutofacServiceProvider(container);
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

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
