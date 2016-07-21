
//-------------------------------------------------------
//
//      Copyright (c) 2016 All Rights Reserved
//          Daikun Industries LLC
//
//-------------------------------------------------------

using System.Collections.Generic;

namespace XIVDB.Model.DataType
{
    /// <summary>
    /// Container class for all model classes that inherit IXIVDBObject
    /// Contains an IEnumerable of returned results and Paging data
    /// </summary>
    /// <typeparam name="IXIVDBObject">The type of IXIVDBObject to instantiate</typeparam>
    public class ResultList<IXIVDBObject> : List<IXIVDBObject>
    {
        public Paging Paging = new Paging();
    }
}
