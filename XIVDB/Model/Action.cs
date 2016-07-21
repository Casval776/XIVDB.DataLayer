
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
    /// Model class for Action data types
    /// </summary>
    public class Action : IXivdbObject
    {
        #region Properties
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("name_ja")]
        public string Name_Ja { get; set; }
        [JsonProperty("name_en")]
        public string Name_En { get; set; }
        [JsonProperty("name_fr")]
        public string Name_Fr { get; set; }
        [JsonProperty("name_de")]
        public string Name_De { get; set; }
        [JsonProperty("name_ch")]
        public string Name_Ch { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public int Level { get; set; }
        [JsonProperty("classjob", NullValueHandling = NullValueHandling.Ignore)]
        public int ClassJob { get; set; }
        [JsonProperty("class_name")]
        public string Class_Name { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("url_api")]
        public string Url_Api { get; set; }
        [JsonProperty("url_xivdb")]
        public string Url_Xivdb { get; set; }
        [JsonProperty("url_xivdb_ja")]
        public string Url_Xivdb_Ja { get; set; }
        [JsonProperty("url_xivdb_fr")]
        public string Url_Xivdb_Fr { get; set; }
        [JsonProperty("url_xivdb_de")]
        public string Url_Xivdb_De { get; set; }
        [JsonProperty("url_type")]
        public string Url_Type { get; set; }
        #endregion
    }
}
