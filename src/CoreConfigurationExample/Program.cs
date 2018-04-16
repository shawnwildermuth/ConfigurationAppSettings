using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using WilderMinds.Configuration.AppSettings;

namespace CoreConfigurationExample
{
  public class Program
  {
    public static void Main(string[] args)
    {
      BuildWebHost(args).Run();
    }

    public static IWebHost BuildWebHost(string[] args) =>
        WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(cfg =>
                {
                  cfg.Sources.Clear();
                  cfg.AddAppSettings();
                })
                .UseStartup<Startup>()
                .Build();
  }
}
