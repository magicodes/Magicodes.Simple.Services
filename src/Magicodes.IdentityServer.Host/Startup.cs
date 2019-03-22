using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Magicodes.IdentityServer.Host
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
            //var connectionString = Configuration.GetConnectionString("Default");
            //services.AddDbContext<MagicodesAdminContext>(options => options.UseSqlServer(connectionString));

            //services.AddIdentity<AbpUsers, AbpRoles>()
            //    .AddEntityFrameworkStores<MagicodesAdminContext>()
            //    .AddDefaultTokenProviders();

            services.AddIdentityServer()
                .AddDeveloperSigningCredential()
                .AddInMemoryPersistedGrants()
                .AddInMemoryIdentityResources(IdentityServerConfig.GetIdentityResources())
                .AddInMemoryApiResources(IdentityServerConfig.GetApiResources())
                .AddInMemoryClients(IdentityServerConfig.GetClients(Configuration))
                //.AddAspNetIdentity<AbpUsers>()
            //从数据库读取配置等内容(clients, resources)
            //.AddConfigurationStore(options =>
            //{
            //    options.ConfigureDbContext = b =>
            //        b.UseSqlServer(connectionString);
            //})

            // this adds the operational data from DB (codes, tokens, consents)
            //.AddOperationalStore(options =>
            //{
            //    options.ConfigureDbContext = b =>
            //        b.UseSqlServer(connectionString);

            //    options.PersistedGrants.Name = "AbpPersistedGrants";
            //    //options.DeviceFlowCodes.Name = 
            //    // this enables automatic token cleanup. this is optional.
            //    options.EnableTokenCleanup = true;
            //});

            //.AddAspNetIdentity()
            //.AddAbpPersistedGrants<AdminDbContext>()
            //.AddAbpIdentityServer<User>();
            ;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("IdentityServer is running!");
            });
        }
    }
}
