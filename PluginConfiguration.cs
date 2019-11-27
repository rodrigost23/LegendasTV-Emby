using MediaBrowser.Common.Configuration;
using MediaBrowser.Model.Serialization;
using System;

namespace LegendasTV
{
    public class PluginConfiguration : MediaBrowser.Model.Plugins.BasePluginConfiguration
    {
    }

    public class Plugin : MediaBrowser.Common.Plugins.BasePlugin<PluginConfiguration>
    {
        public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer) : base(applicationPaths, xmlSerializer)
        {

        }

        public override string Name => "Legendas TV";

        public override string Description => "Get subtitles from Legendas.TV";

        public override Guid Id => new Guid("F54A744C-95DC-499B-A51C-CDD0ECE719B6");

    }
}
