using Core.Localization.Holders.Base;
using Newtonsoft.Json;

namespace Core.Localization.Holders
{
    public class LMain: LBase
    {
        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("history")]
        public string? History { get; set; }

        [JsonProperty("properties")]
        public string? Properties { get; set; }

        [JsonProperty("chords")]
        public string? Chords { get; set; }

        [JsonProperty("layers")]
        public string? Layers { get; set; }

        [JsonProperty("save")]
        public string? Save { get; set; }
    }
}
