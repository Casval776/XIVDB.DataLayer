
//-------------------------------------------------------
//
//      Copyright (c) 2016 All Rights Reserved
//          Daikun Industries LLC
//
//-------------------------------------------------------

using Newtonsoft.Json;

namespace XIVDB.Interfaces
{
    /// <summary>
    /// Currently a dummy interface used as a Generic for objects turned from the API
    /// </summary>
    public interface IXivdbObject
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        int? Id { get; set; }
        //@TODO: Probably add something here? I dunno.
    }
}
