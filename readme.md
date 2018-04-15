# AppSettingsConfiguration

This repository contains the project and example for the WilderMinds.AppSettings Nuget Package.

This package supports reading AppSettings section of a web.config file in the root of the project. It's a simple library to show how simple it is to create a Configuration Extension. 

To use the library, just add the Nuget package via dotnet command-line:

```
dotnet add package WilderMinds.AppSettings
```

To use the library, simply handle the ConfigurateAppConfiguration in the Program.cs and call AddAppSettings like so:

```
  WebHost.CreateDefaultBuilder(args)
         .ConfigureAppConfiguration(cfg =>
         {
           cfg.Sources.Clear();
           cfg.AddAppSettings();
         })
         .UseStartup<Startup>()
         .Build();

```

Please see the blog post for more information:

