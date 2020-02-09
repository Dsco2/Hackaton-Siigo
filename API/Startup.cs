using System;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using IoC;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence;
using Swashbuckle.AspNetCore.Swagger;

namespace API
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

            services.AddSwaggerGen(x =>
            {
                x.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "SIIGO 2020-02-08 Hackaton API documentation",
                    Description = "This documentation is updated automatically based on the API code",
                    TermsOfService = "None",
                    Contact = new Contact
                    {
                        Name = "Spiders Team",
                        Email = "ing-cantor@hotmail.com",
                        Url = "https://tbd.com"
                    }
                });
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<MainContext>();
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterModule<CoreModule>();
            containerBuilder.Populate(services);
            var container = containerBuilder.Build();
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

            app.UseCors(builder => builder.WithOrigins(
                    "http://localhost:3000",
                    "http://hackaton-siigo.s3-website-us-east-1.amazonaws.com"
                )
                .AllowAnyMethod()
                .AllowAnyHeader());

            app.UseHttpsRedirection();
            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(x => { x.SwaggerEndpoint(
                "/swagger/v1/swagger.json", "SIIGO Hackaton API docs"); });
        }
    }
}
