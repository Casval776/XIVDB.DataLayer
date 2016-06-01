using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XIVDB.Enums;

namespace XIVDB.Helpers
{
    public static class RequestHelper
    {
        public static string PrepareQueryString(SearchType searchType, string rawValue)
        {
            return (searchType.ToString() + "=" + rawValue.Trim().Replace(' ', '+'));
        }
    }
}
