using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XIVDB.Model
{
    public class ResultType
    {
        [JsonProperty("quests")]
        public bool Quests { get; set; }
        [JsonProperty("achievements")]
        public bool Achievements { get; set; }
        [JsonProperty("recipes")]
        public bool Recipes { get; set; }
        [JsonProperty("instances")]
        public bool Instances { get; set; }
        [JsonProperty("actions")]
        public bool Actions { get; set; }
        [JsonProperty("places")]
        public bool Places { get; set; }
        [JsonProperty("shops")]
        public bool Shops { get; set; }
        [JsonProperty("gathering")]
        public bool Gathering { get; set; }
        [JsonProperty("npcs")]
        public bool NPCs { get; set; }
        [JsonProperty("enemies")]
        public bool Enemies { get; set; }
        [JsonProperty("emotes")]
        public bool Emotes { get; set; }
        [JsonProperty("status")]
        public bool Status { get; set; }
        [JsonProperty("titles")]
        public bool Titles { get; set; }
        [JsonProperty("minions")]
        public bool Minions { get; set; }
        [JsonProperty("mounts")]
        public bool Mounts { get; set; }
        [JsonProperty("weather")]
        public bool Weather { get; set; }
        public Results Result { get; set; }
    }
}
