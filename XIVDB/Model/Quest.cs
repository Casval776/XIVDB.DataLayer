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
    /// Model class for Quest data types
    /// </summary>
    public class Quest : IXivdbObject
    {
        #region Properties
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
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
        [JsonProperty("header_special", NullValueHandling = NullValueHandling.Ignore)]
        public int? HeaderSpecial { get; set; }
        [JsonProperty("journal_genre", NullValueHandling = NullValueHandling.Ignore)]
        public int? JournalGenre { get; set; }
        [JsonProperty("classjob_category_1", NullValueHandling = NullValueHandling.Ignore)]
        public int? ClassJobCategory1 { get; set; }
        [JsonProperty("classjob_category_2", NullValueHandling = NullValueHandling.Ignore)]
        public int? ClassJobCategory2 { get; set; }
        [JsonProperty("class_level_1", NullValueHandling = NullValueHandling.Ignore)]
        public int? ClassLevel1 { get; set; }
        [JsonProperty("class_level_2", NullValueHandling = NullValueHandling.Ignore)]
        public int? ClassLevel2 { get; set; }
        [JsonProperty("class_1")]
        public string Class1 { get; set; }
        [JsonProperty("genre_name")]
        public string GenreName { get; set; }
        [JsonProperty("category_name")]
        public string CategoryName { get; set; }
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
        [JsonProperty("icon")]
        public string Icon { get; set; }
        #endregion
    }
}
