using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XIVDB.Interfaces;

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
