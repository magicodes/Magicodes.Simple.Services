using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Ocelot.Administration;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;
using Ocelot.Provider.Consul;
using Ocelot.Cache.CacheManager;
using Ocelot.Provider.Polly;

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
            services.AddAuthentication().AddIdentityServerAuthentication("IdentityBearer", options =>
            {
                options.Authority = "http://localhost:2000/";
                options.RequireHttpsMetadata = false;
                options.ApiName = "client";
                options.ApiSecret = "def2edf7-5d42-4edc-a84a-30136c340e13";
                options.SupportedTokens = IdentityServer4.AccessTokenValidation.SupportedTokens.Both;
            });

            services
                .AddOcelot()
                .AddConsul()
                //启用缓存
                .AddCacheManager(x =>
                {
                    x.WithDictionaryHandle();
                })
                .AddPolly()
                .AddAdministration("/administration", options=>
                {
                    options.Authority = "http://localhost:2000/";
                    options.RequireHttpsMetadata = false;
                    options.ApiName = "admin";
                    options.ApiSecret = "07ABB7E9-233B-4ABC-83AB-7D191F7BBF7E";
                    options.SupportedTokens = IdentityServer4.AccessTokenValidation.SupportedTokens.Both;
                }); 

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseOcelot().Wait();
        }
    }
}
