using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using XIVDB.Enums;
using XIVDB.Model;
using XIVDB.Static;
using XIVDB.Helpers;
using Newtonsoft.Json;

namespace XIVDB
{
    public class XIVDBClient
    {
        public XIVDBClient()
        {

        }

        public Results XIVDBQuery(SearchType searchType, string query)
        {
            //For the time being, treat all queries as full text
            //This does not take search prefixes into account
            //Query XIVDB API
            var response = Query(RequestHelper.PrepareQueryString(searchType, query));

            //Start deserializing objects into return types
            var deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response);
            ResultType resultType = new ResultType();
            Results results = new Results();
            Quest quests = new Quest();
            List<Item> resultItems = new List<Item>();
            List<Quest> resultQuests = new List<Quest>();
            try
            {
                //resultType = JsonConvert.DeserializeObject<ResultType>(deserializedResponse.ToString());
                results = JsonConvert.DeserializeObject<Results>(deserializedResponse.items.ToString());

                //Iterate through the collection of Items returned
                foreach (var resultsChild in JsonConvert.DeserializeObject(deserializedResponse.items.results.ToString()).Children())
                {
                    resultItems.Add(JsonConvert.DeserializeObject<Item>(resultsChild.ToString()));
                }

                //Iterate through the collection of Quests returned
                foreach (var resultsChild in JsonConvert.DeserializeObject(deserializedResponse.quests.results.ToString()).Children())
                {
                    resultQuests.Add(JsonConvert.DeserializeObject<Quest>(resultsChild.ToString()));
                }
                results.ResultItems = resultItems;
                resultType.Result = results;
            }
            catch (Exception ex)
            {
                //Do nothing
            }

            //Return Items
            return results;
        }

        private string Query(string query)
        {
            StreamReader reader = null;
            HttpWebResponse apiResponse = null;
            try
            {
                HttpWebRequest apiRequest = (HttpWebRequest)WebRequest.Create(APIConstants.URI.APIURL + query);
                apiRequest.Method = APIConstants.URI.APIRequestMethod;
                apiRequest.Accept = APIConstants.URI.APIRequestAccept;

                string response = string.Empty;
                apiResponse = (HttpWebResponse)apiRequest.GetResponse();
                using (reader = new StreamReader(apiResponse.GetResponseStream()))
                {
                    response = reader.ReadToEnd();
                }
                return response;
            }
            catch (Exception ex)
            {
                //Probably should create logging here
                return string.Empty;
            }
            finally
            {
                if (reader != null) reader.Dispose();
                if (apiResponse != null) apiResponse.Dispose();
            }

        }
    }
}
