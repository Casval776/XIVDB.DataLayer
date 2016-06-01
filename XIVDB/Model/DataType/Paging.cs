using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace XIVDB.Model.DataType
{
    /// <summary>
    /// Paging holds data for the "paging" portion of the JSON return string
    /// Includes page number, total pages, total objects, next, and prev pages
    /// </summary>
    public class Paging
    {
        #region Properties
        [JsonProperty("page", NullValueHandling = NullValueHandling.Ignore)]
        public int Page { get; set; }
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int Total { get; set; }
        [JsonProperty("pages")]
        public List<int> Pages { get; set; }
        [JsonProperty("next", NullValueHandling = NullValueHandling.Ignore)]
        public int Next { get; set; }
        [JsonProperty("prev", NullValueHandling = NullValueHandling.Ignore)]
        public int Prev { get; set; }
        #endregion
    }
}
