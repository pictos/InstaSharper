using System;
using System.Threading.Tasks;
using InstaSharper.API;
using InstaSharper.Classes;

namespace InstaSharper.Examples.Samples
{
    internal class CommentMedia : IDemoSample
    {
        private readonly IInstaApi _instaApi;

        public CommentMedia(IInstaApi instaApi)
        {
            _instaApi = instaApi;
        }

        public async Task DoShow()
        {
            await _instaApi.LoginAsync();
            var media = await _instaApi.GetUserTimelineFeedAsync(PaginationParameters.MaxPagesToLoad(2));
            var id = media.Value.Medias[0].InstaIdentifier;

            var commentResult = await _instaApi.CommentMediaAsync(id, "Hi there!");
            Console.WriteLine(commentResult.Succeeded
                ? $"Comment created: {commentResult.Value.Pk}, text: {commentResult.Value.Text}"
                : $"Unable to create comment: {commentResult.Info.Message}");
        }
    }
}