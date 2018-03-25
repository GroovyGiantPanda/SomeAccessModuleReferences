﻿namespace TwitchLib.Models.API.v5.Collections
{
    #region using directives
    using Newtonsoft.Json;
    #endregion
    public class CollectionsByChannel
    {
        #region Cursor
        [JsonProperty(PropertyName = "_cursor")]
        public string Cursor { get; protected set; }
        #endregion
        #region Collections
        [JsonProperty(PropertyName = "collections")]
        public CollectionMetadata[] Collections { get; protected set; }
        #endregion
    }
}
