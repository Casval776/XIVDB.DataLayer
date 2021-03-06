﻿//-------------------------------------------------------
//
//      Copyright (c) 2016 All Rights Reserved
//          Daikun Industries LLC
//
//-------------------------------------------------------

using XIVDB.Enums;
using XIVDB.Static;

namespace XIVDB.Helpers
{
    /// <summary>
    /// Static Helper class for all Request related tasks
    /// </summary>
    public static class RequestHelper
    {
        #region Public Functions
        /// <summary>
        /// Sterilizes and cleans user entered data used in the API Query
        /// </summary>
        /// <param name="searchType">Enums.SearchType used to differentiate between different search types</param>
        /// <param name="rawValue">The user entered string</param>
        /// <returns></returns>
        public static string PrepareQueryString(SearchType searchType, string rawValue)
        {
            return (
                (searchType.ToString() == SearchType.Text.ToString() ? 
                "string" 
                : searchType.ToString()) + 
                "=" + rawValue.Trim().Replace(' ', ApiConstants.Uri.WhitespaceDelimiter));
        }
        #endregion
    }
}
