using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DJAmlin.Configuration
{
    public static class StartupConfiguration
    {
        public static IConfigurationSection GetLoggerConfiguration(this IConfiguration config)
        {
            return config.GetSection("Logging");
        }

        public static T Get<T>(this IConfiguration config, string name)
        {
            return config
                 .GetSection(name)
                 .Get<T>();
        }
    }
}
