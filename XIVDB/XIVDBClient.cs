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
using XIVDB.Exceptions;
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

            //Instantiate result container
            Results results = new Results();

            try
            {
                //Begin filling child element collections
                results.Items = ResponseHelper.Deserialize<Item>(deserializedResponse.items);
                results.Quests = ResponseHelper.Deserialize<Quest>(deserializedResponse.quests);
                results.Actions = ResponseHelper.Deserialize<Model.Action>(deserializedResponse.actions);
                results.Achievements = ResponseHelper.Deserialize<Achievement>(deserializedResponse.achievements);
                results.Recipes = ResponseHelper.Deserialize<Recipe>(deserializedResponse.recipes);
                //resultType.Result = results;
            }
            catch (APIErrorException apiex)
            {
                //Do nothing
                Console.WriteLine(apiex.Message);
                if (apiex.InnerException != null) Console.WriteLine(apiex.InnerException.Message);
                Console.ReadKey();
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
