using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;

namespace WilderMinds.Configuration.AppSettings
{



  public class AppSettingsConfigurationProvider : FileConfigurationProvider
  {
    public AppSettingsConfigurationProvider(AppSettingsConfigurationSource source) : base(source)
    {

    }

    public override void Load(Stream stream)
    {
      try
      {
        Data = ReadAppSettings(stream);
      }
      catch
      {
        throw new FormatException("Failed to read from web.config");
      }
    }

    private IDictionary<string, string> ReadAppSettings(Stream stream)
    {
      var data = new SortedDictionary<string, string>(StringComparer.OrdinalIgnoreCase);
      var doc = new XmlDocument();
      doc.Load(stream);

      var appSettings = doc.SelectNodes("/configuration/appSettings/add");

      foreach (XmlNode child in appSettings)
      {
        data[child.Attributes["key"].Value] = child.Attributes["value"].Value;
      }

      return data;
    }
  }

}


