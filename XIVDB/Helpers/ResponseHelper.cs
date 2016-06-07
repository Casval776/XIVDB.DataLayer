using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XIVDB.Model;
using XIVDB.Interfaces;
using Newtonsoft.Json;
using XIVDB.Model.DataType;
using log4net;

namespace XIVDB.Helpers
{
    /// <summary>
    /// Public static class used for all Response related functions, 
    /// including parsing and deserializing.
    /// </summary>
    public static class ResponseHelper
    {
        #region Private Variables
        private static readonly ILog log = log4net.LogManager.GetLogger(typeof(ResponseHelper));
        #endregion

        #region Public Functions
        /// <summary>
        /// Function used to deserialize objects from raw JSON into a ResultList object.
        /// </summary>
        /// <typeparam name="T">The IXIVDBObject type</typeparam>
        /// <param name="jsonString">The Dynamic Object created during response read</param>
        /// <returns>ResultList of type T, where T is an IXIVDBObject</returns>
        public static IEnumerable<T> Deserialize<T>(dynamic jsonString) where T : IXIVDBObject
        {
            //Instantiate container
            ResultList<T> resultList = new ResultList<T>();
            try
            {
                log.Info("[" + DateTime.Now + "] - Beginning deserialization of [" + jsonString.results.Count + "] objects of type [" + typeof(T).ToString() + "]");
                //Iterate through child elements to build result set
                foreach (var resultsChild in jsonString.results.Children())
                {
                    resultList.Add(JsonConvert.DeserializeObject<T>(resultsChild.ToString()));
                }

                //Grab total and paging data
                resultList.Paging.Total = Convert.ToInt32(JsonConvert.DeserializeObject<int>(jsonString.total.ToString()));
                resultList.Paging = JsonConvert.DeserializeObject<Paging>(jsonString.paging.ToString());
                log.Info("[" + DateTime.Now + "] - Finished deserialization");
            }
            catch (Exception ex)
            {
                log.Error("[" + DateTime.Now + "] - Error Encountered in [ResponseHelper]\nDetails: " + ex.Message +
                    "\n\nInner Details: " +
                    (ex.InnerException.Message == null ? "No Data..." : ex.InnerException.Message));
                return resultList;
            }
            //Return result
            return resultList;
        }
        #endregion
    }
}
