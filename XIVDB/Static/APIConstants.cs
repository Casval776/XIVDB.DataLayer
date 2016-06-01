//--------------------------------------------
//
//      Copyright (c) 2016 All Rights Reserved
//          Daikun Industries LLC
//
//--------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XIVDB.Static
{
    /// <summary>
    /// Public Struct class used to hold constant values used throughout the DataLayer
    /// </summary>
    public static class APIConstants
    {
        /// <summary>
        /// Holds URI-related constant values
        /// </summary>
        public struct URI
        {
            public const string APIURL = @"http://api.xivdb.com/search?";
            public const string APIRequestMethod = "GET";
            public const string APIRequestAccept = "application/json";
            public const char WhitespaceDelimiter = '+';
        }
    }
}
