using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using XIVDB.Interfaces;

namespace XIVDB.Model
{
    /// <summary>
    /// Model class for Recipe data types
    /// </summary>
    public class Recipe : IXIVDBObject
    {
        #region Properties
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("classjob", NullValueHandling = NullValueHandling.Ignore)]
        public int ClassJob { get; set; }
        [JsonProperty("level", NullValueHandling = NullValueHandling.Ignore)]
        public int Level { get; set; }
        [JsonProperty("level_view", NullValueHandling = NullValueHandling.Ignore)]
        public int Level_View { get; set; }
        [JsonProperty("level_diff", NullValueHandling = NullValueHandling.Ignore)]
        public int Level_Diff { get; set; }
        [JsonProperty("item_name")]
        public string Item_Name { get; set; }
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
        [JsonProperty("icon_lodestone")]
        public string Icon_Lodestone { get; set; }
        [JsonProperty("item_rarity", NullValueHandling = NullValueHandling.Ignore)]
        public int Item_Rarity { get; set; }
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
        [JsonProperty("color")]
        public string Color { get; set; }
        [JsonProperty("stars", NullValueHandling = NullValueHandling.Ignore)]
        public int Stars { get; set; }
        [JsonProperty("stars_html")]
        public string Stars_Html { get; set; }
        [JsonProperty("difficulty_factor", NullValueHandling = NullValueHandling.Ignore)]
        public int Difficulty_Factor { get; set; }
        [JsonProperty("durability_factor", NullValueHandling = NullValueHandling.Ignore)]
        public int Durability_Factor { get; set; }
        [JsonProperty("quality_factor", NullValueHandling = NullValueHandling.Ignore)]
        public int Quality_Factor { get; set; }
        [JsonProperty("difficulty", NullValueHandling = NullValueHandling.Ignore)]
        public int Difficulty { get; set; }
        [JsonProperty("durability", NullValueHandling = NullValueHandling.Ignore)]
        public int Durability { get; set; }
        [JsonProperty("quality", NullValueHandling = NullValueHandling.Ignore)]
        public int Quality { get; set; }
        #endregion
    }
}
