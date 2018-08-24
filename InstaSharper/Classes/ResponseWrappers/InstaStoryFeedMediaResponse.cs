using Newtonsoft.Json;

namespace InstaSharper.Classes.ResponseWrappers
{
    public class InstaStoryFeedMediaResponse : InstaStoryMediaBaseR
    {
        [JsonProperty("media_id")] public long MediaId { get; set; }
    }
}
