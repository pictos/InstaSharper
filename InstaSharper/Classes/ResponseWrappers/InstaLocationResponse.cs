using Newtonsoft.Json;

namespace InstaSharper.Classes.ResponseWrappers
{
    public class InstaLocationResponse : InstaStoryMediaBaseR
    {
        [JsonProperty("location")] public InstaLocationShortResponse Location { get; set; }
    }
}