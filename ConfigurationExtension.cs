using System.Collections.Generic;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Model.Providers;

namespace LegendasTV
{
    public static class ConfigurationExtension
    {
        public static LegendasTVOptions GetLegendasTVConfiguration(this IConfigurationManager manager)
        {
            return manager.GetConfiguration<LegendasTVOptions>("legendastv");
        }
    }

    public class LegendasTVConfigurationFactory : IConfigurationFactory
    {
        public IEnumerable<ConfigurationStore> GetConfigurations()
        {
            return new ConfigurationStore[]
            {
                new ConfigurationStore
                {
                    Key = "legendastv",
                    ConfigurationType = typeof (LegendasTVOptions)
                }
            };
        }
    }

    public class LegendasTVOptions
    {
        public string LegendasTVUsername { get; set; }
        public string LegendasTVPasswordHash { get; set; }
    }
}