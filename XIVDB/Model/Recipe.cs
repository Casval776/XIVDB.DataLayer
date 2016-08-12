
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
    /// Model class for Recipe data types
    /// </summary>
    public class Recipe : IXivdbObject
    {
        #region Properties
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("classjob", NullValueHandling = NullValueHandling.Ignore)]
        public int? ClassJob { get; set; }
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public int? Level { get; set; }
        [JsonProperty("level_view", NullValueHandling = NullValueHandling.Ignore)]
        public int? LevelView { get; set; }
        [JsonProperty("level_diff", NullValueHandling = NullValueHandling.Ignore)]
        public int? LevelDiff { get; set; }
        [JsonProperty("item_name")]
        public string ItemName { get; set; }
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
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("icon_lodestone")]
        public string IconLodestone { get; set; }
        [JsonProperty("item_rarity", NullValueHandling = NullValueHandling.Ignore)]
        public int? ItemRarity { get; set; }
        [JsonProperty("class_name")]
        public string ClassName { get; set; }
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
        [JsonProperty("stars", NullValueHandling = NullValueHandling.Ignore)]
        public int? Stars { get; set; }
        [JsonProperty("stars_html")]
        public string StarsHtml { get; set; }
        [JsonProperty("difficulty_factor", NullValueHandling = NullValueHandling.Ignore)]
        public int? DifficultyFactor { get; set; }
        [JsonProperty("durability_factor", NullValueHandling = NullValueHandling.Ignore)]
        public int? DurabilityFactor { get; set; }
        [JsonProperty("quality_factor", NullValueHandling = NullValueHandling.Ignore)]
        public int? QualityFactor { get; set; }
        [JsonProperty("difficulty", NullValueHandling = NullValueHandling.Ignore)]
        public int? Difficulty { get; set; }
        [JsonProperty("durability", NullValueHandling = NullValueHandling.Ignore)]
        public int? Durability { get; set; }
        [JsonProperty("quality", NullValueHandling = NullValueHandling.Ignore)]
        public int? Quality { get; set; }
        #endregion
    }
}
