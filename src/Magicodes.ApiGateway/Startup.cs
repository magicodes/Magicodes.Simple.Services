using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.PlatformAbstractions;
using Ocelot.Administration;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Ocelot.Provider.Consul;
using Ocelot.Cache.CacheManager;
using Ocelot.Provider.Polly;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.AspNetCore.Mvc;
using IdentityServer4.AccessTokenValidation;

namespace Magicodes.ApiGateway.Host
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Identity Server Bearer Tokens

            Action<IdentityServerAuthenticationOptions> isaOpt = option =>
            {
                option.Authority = Configuration["IdentityService:Uri"];
                option.RequireHttpsMetadata = Convert.ToBoolean(Configuration["IdentityService:UseHttps"]);
                option.ApiName = Configuration["IdentityService:ApiName"];
                option.ApiSecret = Configuration["IdentityService:ApiSecret"];
                option.SupportedTokens = SupportedTokens.Both;
            };

            services.AddAuthentication().AddIdentityServerAuthentication(Configuration["IdentityService:DefaultScheme"], isaOpt);

            services
                .AddOcelot(Configuration)
                .AddConsul()
                //启用缓存
                .AddCacheManager(x => { x.WithDictionaryHandle(); })
                .AddPolly()
                .AddAdministration("/administration", isaOpt);
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2); ;
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc(Configuration["Swagger:Name"], new Info { Title = Configuration["Swagger:Title"], Version = Configuration["Swagger:Version"] });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            var apis = Configuration["Apis:SwaggerNames"].Split(";").ToList();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvc()
              .UseSwagger()
              .UseSwaggerUI(options =>
              {
                  apis.ToList().ForEach(key =>
                  {
                      options.SwaggerEndpoint($"/{key}/swagger.json", key);
                  });
                  options.DocumentTitle = "网关";
              });
            app.UseOcelot().Wait();
        }
    }
}
