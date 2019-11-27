using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Drawing;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LegendasTV
{

    public class Plugin : BasePlugin, IHasWebPages, IHasThumbImage
    {
        public override string Name => "Legendas TV";

        public override string Description => "Get subtitles from Legendas.TV";

        public override Guid Id => new Guid("F54A744C-95DC-499B-A51C-CDD0ECE719B6");

        public IEnumerable<PluginPageInfo> GetPages() => new[]
            {
                new PluginPageInfo
                {
                    Name = "legendastv",
                    EmbeddedResourcePath = GetType().Namespace + ".Configuration.legendastv.html",
                    EnableInMainMenu = true,
                    MenuSection = "server",
                    MenuIcon = "closed_caption"
                },
                new PluginPageInfo
                {
                    Name = "legendastvjs",
                    EmbeddedResourcePath = GetType().Namespace + ".Configuration.legendastv.js"
                }
            };

        public Stream GetThumbImage()
        {
            var type = GetType();
            return type.Assembly.GetManifestResourceStream(type.Namespace + ".thumb.png");
        }

        public ImageFormat ThumbImageFormat => ImageFormat.Png;

    }
}
