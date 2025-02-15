﻿using Microsoft.Extensions.Configuration;

namespace ExtensionMethods.Library
{
    public static class ConfigurationExtensions
    {
        public static bool IsLoaded(this IConfiguration config)
        {
            return config != null && config.AsEnumerable().Any();
        }

        public static IConfigurationBuilder AddStandardProviders(this IConfigurationBuilder configBuilder)
        {
            return configBuilder.AddJsonFile("appSettings.json")
                                .AddEnvironmentVariables()
                                .AddJsonFile("config/config.json", optional: true)
                                .AddJsonFile("secrets/secrets.json", optional: true);
        }

    }
}
