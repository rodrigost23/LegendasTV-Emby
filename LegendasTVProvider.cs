using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediaBrowser.Controller.Providers;
using MediaBrowser.Controller.Subtitles;
using MediaBrowser.Model.Logging;
using MediaBrowser.Model.Providers;

namespace LegendasTV
{
    class LegendasTVProvider : ISubtitleProvider, IDisposable
    {
        private readonly ILogger _logger;

        public string Name => "Legendas TV";

        public IEnumerable<VideoContentType> SupportedMediaTypes => new[] { VideoContentType.Episode, VideoContentType.Movie };

        public async Task<SubtitleResponse> GetSubtitles(string id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<RemoteSubtitleInfo>> Search(SubtitleSearchRequest request, CancellationToken cancellationToken)
        {
            return new[] {
                new RemoteSubtitleInfo {
                    ThreeLetterISOLanguageName = "pob",
                    Id = "1",
                    ProviderName = "Legendas TV",
                    Name = "Dummy Result 1",
                    Format = "srt",
                    Author = "Author",
                    Comment = "Do not try to download this",
                    DateCreated = new DateTimeOffset(),
                    CommunityRating = 5f,
                    DownloadCount = 100,
                    IsHashMatch = false,
                    IsForced = false
                },
                new RemoteSubtitleInfo {
                    ThreeLetterISOLanguageName = "pob",
                    Id = "2",
                    ProviderName = "Legendas TV",
                    Name = "Dummy Result 2",
                    Format = "srt",
                    Author = "Author",
                    Comment = "Do not try to download this",
                    DateCreated = new DateTimeOffset(),
                    CommunityRating = 2f,
                    DownloadCount = 150,
                    IsHashMatch = true,
                    IsForced = false
                }
            };
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}