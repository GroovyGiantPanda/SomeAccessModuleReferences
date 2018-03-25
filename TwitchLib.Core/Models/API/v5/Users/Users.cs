﻿namespace TwitchLib.Models.API.v5.Users
{
    #region using directives
    using Newtonsoft.Json;
    #endregion
    public class Users
    {
        #region Total
        [JsonProperty(PropertyName ="_total")]
        public int Total { get; protected set; }
        #endregion
        #region Users
        [JsonProperty(PropertyName ="users")]
        public User[] Matches { get; protected set; }
        #endregion
    }
}
