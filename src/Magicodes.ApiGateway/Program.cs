using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Magicodes.ApiGateway.Host
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) => new WebHostBuilder()
               .UseKestrel((context, opt) =>
               {
                   opt.AddServerHeader = false;
                   ////从配置文件读取配置
                   //opt.Configure(context.Configuration.GetSection("Kestrel"));
               })
               .UseContentRoot(Directory.GetCurrentDirectory())
               .ConfigureAppConfiguration((hostingContext, config) =>
               {
                   var env = hostingContext.HostingEnvironment;
                   //根据环境变量加载不同的JSON配置
                   config.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                      .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true, reloadOnChange: true)
                      .AddJsonFile("ocelot.json")
                      .AddEnvironmentVariables(); //从环境变量添加配置
               })
               .UseIISIntegration()
               .ConfigureLogging((hostingContext, logging) =>
               {
                   logging.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
                   //添加控制台日志,Docker环境下请务必启用
                   logging.AddConsole();
                   //添加调试日志
                   logging.AddDebug();
               })
               .UseStartup<Startup>();
    }
}
