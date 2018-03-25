using Newtonsoft.Json;

namespace TwitchLib.Models.API.v3.Root
{
    public class RootResponse
    {
        [JsonProperty(PropertyName = "identified")]
        public bool Identified { get; protected set; }
        [JsonProperty(PropertyName = "token")]
        public Token Token { get; protected set; } 
    }
}
