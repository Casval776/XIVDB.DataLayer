
//-------------------------------------------------------
//
//      Copyright (c) 2016 All Rights Reserved
//          Daikun Industries LLC
//
//-------------------------------------------------------

using Newtonsoft.Json;
using XIVDB.Interfaces;

namespace XIVDB.Model
{
    /// <summary>
    /// Model class for Gathering data types
    /// </summary>
    public class Gathering : IXivdbObject
    {
        #region Properties
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("name_ja")]
        public string name_ja { get; set; }
        [JsonProperty("name_en")]
        public string name_en { get; set; }
        [JsonProperty("name_fr")]
        public string name_fr { get; set; }
        [JsonProperty("name_de")]
        public string name_de { get; set; }
        [JsonProperty("name_ch")]
        public string name_ch { get; set; }
        [JsonProperty("item")]
        public int item { get; set; }
        [JsonProperty("level")]
        public int level { get; set; }
        [JsonProperty("level_view")]
        public int level_view { get; set; }
        [JsonProperty("level_diff")]
        public int level_diff { get; set; }
        [JsonProperty("type_name")]
        public string type_name { get; set; }
        [JsonProperty("item_level_equip")]
        public int item_level_equip { get; set; }
        [JsonProperty("item_level_item")]
        public int item_level_item { get; set; }
        [JsonProperty("rarity")]
        public int rarity { get; set; }
        [JsonProperty("icon")]
        public string icon { get; set; }
        [JsonProperty("icon_lodestone")]
        public string icon_lodestone { get; set; }
        [JsonProperty("url")]
        public string url { get; set; }
        [JsonProperty("url_api")]
        public string url_api { get; set; }
        [JsonProperty("url_xivdb")]
        public string url_xivdb { get; set; }
        [JsonProperty("url_xivdb_ja")]
        public string url_xivdb_ja { get; set; }
        [JsonProperty("url_xivdb_fr")]
        public string url_xivdb_fr { get; set; }
        [JsonProperty("url_xivdb_de")]
        public string url_xivdb_de { get; set; }
        [JsonProperty("url_type")]
        public string url_type { get; set; }
        [JsonProperty("color")]
        public string color { get; set; }
        [JsonProperty("stars")]
        public int stars { get; set; }
        [JsonProperty("stars_html")]
        public string stars_html { get; set; }
        #endregion
    }
}
