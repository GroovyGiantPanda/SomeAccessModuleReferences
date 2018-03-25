﻿namespace TwitchLib.Models.API.v5.Chat
{
    #region using directives
    using Newtonsoft.Json;
    #endregion
    public class EmoticonImage
    {
        #region Width
        [JsonProperty(PropertyName = "width")]
        public int Width { get; protected set; }
        #endregion
        #region Height
        [JsonProperty(PropertyName = "height")]
        public int Height { get; protected set; }
        #endregion
        #region Url
        [JsonProperty(PropertyName = "url")]
        public string Url { get; protected set; }
        #endregion
        #region EmoticonSet
        [JsonProperty(PropertyName = "emoticon_set")]
        public int EmoticonSet { get; protected set; }
        #endregion
    }
}
