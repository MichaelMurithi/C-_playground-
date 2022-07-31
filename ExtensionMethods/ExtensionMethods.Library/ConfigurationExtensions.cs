using Microsoft.Extensions.Configuration;

namespace ExtensionMethods.Library
{
    public static class ConfigurationExtensions
    {
        public static bool IsLoaded(this IConfiguration config)
        {
            return config != null && config.AsEnumerable().Any();
        }

    }
}
