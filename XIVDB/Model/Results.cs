using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace XIVDB.Model
{
    public class Results
    {
        [JsonProperty("total")]
        public int Total { get; set; }
        public IEnumerable<Item> ResultItems { get; set; }
    }
}
