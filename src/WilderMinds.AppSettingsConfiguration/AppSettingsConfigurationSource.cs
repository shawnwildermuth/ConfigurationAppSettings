using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace WilderMinds.Configuration.AppSettings
{
  public class AppSettingsConfigurationSource : FileConfigurationSource
  {
    public override IConfigurationProvider Build(IConfigurationBuilder builder)
    {
      EnsureDefaults(builder);
      return new AppSettingsConfigurationProvider(this);
    }
  }
}
