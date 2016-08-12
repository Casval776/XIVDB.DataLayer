
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
        public int? Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("name_ja")]
        public string NameJa { get; set; }
        [JsonProperty("name_en")]
        public string NameEn { get; set; }
        [JsonProperty("name_fr")]
        public string NameFr { get; set; }
        [JsonProperty("name_de")]
        public string NameDe { get; set; }
        [JsonProperty("name_ch")]
        public string NameCh { get; set; }
        [JsonProperty("item")]
        public int? Item { get; set; }
        [JsonProperty("level")]
        public int? Level { get; set; }
        [JsonProperty("level_view")]
        public int? LevelView { get; set; }
        [JsonProperty("level_diff")]
        public int? LevelDiff { get; set; }
        [JsonProperty("type_name")]
        public string TypeName { get; set; }
        [JsonProperty("item_level_equip")]
        public int? ItemLevelEquip { get; set; }
        [JsonProperty("item_level_item")]
        public int? ItemLevelItem { get; set; }
        [JsonProperty("rarity")]
        public int? Rarity { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("icon_lodestone")]
        public string IconLodestone { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("url_api")]
        public string UrlApi { get; set; }
        [JsonProperty("url_xivdb")]
        public string UrlXivdb { get; set; }
        [JsonProperty("url_xivdb_ja")]
        public string UrlXivdbJa { get; set; }
        [JsonProperty("url_xivdb_fr")]
        public string UrlXivdbFr { get; set; }
        [JsonProperty("url_xivdb_de")]
        public string UrlXivdbDe { get; set; }
        [JsonProperty("url_type")]
        public string UrlType { get; set; }
        [JsonProperty("color")]
        public string Color { get; set; }
        [JsonProperty("stars")]
        public int? Stars { get; set; }
        [JsonProperty("stars_html")]
        public string StarsHtml { get; set; }
        #endregion
    }
}
