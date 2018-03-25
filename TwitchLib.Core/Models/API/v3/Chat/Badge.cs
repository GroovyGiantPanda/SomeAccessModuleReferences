﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitchLib.Models.API.v3.Chat
{
    public class Badge
    {
        [JsonProperty(PropertyName = "alpha")]
        public string Alpha { get; protected set; }
        [JsonProperty(PropertyName = "image")]
        public string Image { get; protected set; }
        [JsonProperty(PropertyName = "svg")]
        public string SVG { get; protected set; }
    }
}
