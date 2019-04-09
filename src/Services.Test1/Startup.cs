using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Consul;
using DotNetCore.CAP;
using IdentityServer4.AccessTokenValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.PlatformAbstractions;
using Swashbuckle.AspNetCore.Swagger;

namespace Services.Test1
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
            services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("Default")));
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            
            Action<CapOptions> capOptions = option =>
            {
                option.UseEntityFramework<AppDbContext>();
                option.UseSqlServer(Configuration.GetConnectionString("Default"));
                option.UseRabbitMQ("localhost");
                option.UseDashboard();
                if (Convert.ToBoolean(Configuration["Cap:UseConsul"]))
                {
                    option.UseDiscovery(discovery =>
                    {
                        discovery.DiscoveryServerHostName = Configuration["Cap:DiscoveryServerHostName"];
                        discovery.DiscoveryServerPort = Convert.ToInt32(Configuration["Cap:DiscoveryServerPort"]);
                        discovery.CurrentNodeHostName = Configuration["Cap:CurrentNodeHostName"];
                        discovery.CurrentNodePort = Convert.ToInt32(Configuration["Cap:CurrentNodePort"]);
                        discovery.NodeId = Convert.ToInt32(Configuration["Cap:NodeId"]);
                        discovery.NodeName = Configuration["Cap:NodeName"];
                        discovery.MatchPath = Configuration["Cap:MatchPath"];
                    });
                }

            };
            
            services.AddCap(capOptions);
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("SwaggerAPI1", new Info { Title = "API1", Version = "v1" });
                var basePath = PlatformServices.Default.Application.ApplicationBasePath;
                var xmlPath = Path.Combine(basePath, "Services.Test1.xml");
                options.IncludeXmlComments(xmlPath);
            });

            //服务注册
            //services.Configure<ServiceRegistrationOptions>
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger(c => { c.RouteTemplate = "{documentName}/swagger.json"; });
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/SwaggerAPI1/swagger.json", "API1");
            });
            app.UseMvc();
        }
    }
}
