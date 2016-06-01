﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using XIVDB.Interfaces;

namespace XIVDB.Model
{
    /// <summary>
    /// Model class for FATE data types
    /// </summary>
    public class FATE : IXIVDBObject
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
        public object name_ch { get; set; }
        [JsonProperty("class_level")]
        public int class_level { get; set; }
        [JsonProperty("icon")]
        public string icon { get; set; }
        [JsonProperty("placename")]
        public object placename { get; set; }
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
        [JsonProperty("icon_map")]
        public string icon_map { get; set; }
        [JsonProperty("icon_map_size")]
        public int icon_map_size { get; set; }
        #endregion
    }
}