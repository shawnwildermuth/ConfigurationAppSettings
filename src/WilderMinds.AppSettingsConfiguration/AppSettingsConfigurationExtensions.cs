using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace WilderMinds.Configuration.AppSettings
{ 
  public static class AppSettingConfigurationExtensions
  {
    public static IConfigurationBuilder AddAppSettings(this IConfigurationBuilder bldr)
    {
      return bldr.Add(new AppSettingsConfigurationSource());
    }
  }
}
