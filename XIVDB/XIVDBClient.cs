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
using log4net;
using log4net.Config;

namespace XIVDB
{
    public sealed class XIVDBClient
    {
        private static readonly ILog log = log4net.LogManager.GetLogger(typeof(XIVDBClient));
        //Singleton Instance
        private static readonly XIVDBClient instance = new XIVDBClient();
        private XIVDBClient()
        {
            XmlConfigurator.Configure();
            log.Info("[" + DateTime.Now + "] - XIVDBClient instantiated.");
        }

        static XIVDBClient()
        {

        }

        public static XIVDBClient Instance
        {
            get
            {
                log.Info("[" + DateTime.Now + "] - XIVDBClient Instance requested.");
                return instance;
            }
        }

        public Results XIVDBQuery(SearchType searchType, string query)
        {
            log.Info("[" + DateTime.Now + "] - Beginning query on Query Type [" + searchType.ToString() + "] with params [" + query + "]");
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
                //NOTE: Reflection was necessary because properties don't have implicit types 
                //on dynamic objects. Switch Cases won't work unless Reflection is used
                foreach (var childNode in deserializedResponse.Children())
                {
                    string nodeType = childNode.GetType().GetProperty("Name").GetValue(childNode, null).ToString();

                    //Begin filling child element collections
                    switch (nodeType)
                    {
                        case APIConstants.ReturnNode.Achievements:
                            results.Achievements = ResponseHelper.Deserialize<Achievement>(deserializedResponse.achievements);
                            break;
                        case APIConstants.ReturnNode.Actions:
                            results.Actions = ResponseHelper.Deserialize<Model.Action>(deserializedResponse.actions);
                            break;
                        case APIConstants.ReturnNode.Emotes:
                            results.Emotes = ResponseHelper.Deserialize<Emote>(deserializedResponse.emotes);
                            break;
                        case APIConstants.ReturnNode.Enemies:
                            results.Enemies = ResponseHelper.Deserialize<Enemy>(deserializedResponse.enemies);
                            break;
                        case APIConstants.ReturnNode.FATEs:
                            results.FATEs = ResponseHelper.Deserialize<FATE>(deserializedResponse.fates);
                            break;
                        case APIConstants.ReturnNode.Gathering:
                            results.Gathering = ResponseHelper.Deserialize<Gathering>(deserializedResponse.gathering);
                            break;
                        case APIConstants.ReturnNode.Instances:
                            results.Instances = ResponseHelper.Deserialize<Instance>(deserializedResponse.instances);
                            break;
                        case APIConstants.ReturnNode.Items:
                            results.Items = ResponseHelper.Deserialize<Item>(deserializedResponse.items);
                            break;
                        case APIConstants.ReturnNode.Leves:
                            results.Leves = ResponseHelper.Deserialize<Leve>(deserializedResponse.leves);
                            break;
                        case APIConstants.ReturnNode.Minions:
                            results.Minions = ResponseHelper.Deserialize<Minion>(deserializedResponse.minions);
                            break;
                        case APIConstants.ReturnNode.Mounts:
                            results.Mounts = ResponseHelper.Deserialize<Mount>(deserializedResponse.mounts);
                            break;
                        case APIConstants.ReturnNode.NPCs:
                            results.NPCs = ResponseHelper.Deserialize<NPC>(deserializedResponse.npcs);
                            break;
                        case APIConstants.ReturnNode.Places:
                            results.Places = ResponseHelper.Deserialize<Place>(deserializedResponse.places);
                            break;
                        case APIConstants.ReturnNode.Quests:
                            results.Quests = ResponseHelper.Deserialize<Quest>(deserializedResponse.quests);
                            break;
                        case APIConstants.ReturnNode.Recipes:
                            results.Recipes = ResponseHelper.Deserialize<Recipe>(deserializedResponse.recipes);
                            break;
                        case APIConstants.ReturnNode.Status:
                            results.Statuses = ResponseHelper.Deserialize<Status>(deserializedResponse.status);
                            break;
                        case APIConstants.ReturnNode.Titles:
                            results.Titles = ResponseHelper.Deserialize<Title>(deserializedResponse.titles);
                            break;
                        case APIConstants.ReturnNode.Weather:
                            results.Weathers = ResponseHelper.Deserialize<Weather>(deserializedResponse.weather);
                            break;
                        //Default case in case a new return type is introduced
                        default: //Logging goes here
                            break;
                    }
                }
                log.Info("[" + DateTime.Now + "] - Response deserialization finished");
            }
            catch (Exception ex)
            {
                //Do nothing
                log.Error("[" + DateTime.Now + "] - Error Encountered in [XIVDBClient.XIVDBQuery]\nDetails: " + ex.Message + 
                    "\n\nInner Details: " + 
                    (ex.InnerException.Message == null ? "No Data..." : ex.InnerException.Message));
            }

            //Return Items
            return results;
        }

        /// <summary>
        /// Configures the request and sends it to the XIVDB API.
        /// </summary>
        /// <param name="query">SearchType and search string</param>
        /// <returns>JSON Response in string format</returns>
        private string Query(string query)
        {
            //Instantiate required variables to read and write to API
            StreamReader reader = null;
            HttpWebResponse apiResponse = null;
            try
            {
                //Set request properties
                HttpWebRequest apiRequest = (HttpWebRequest)WebRequest.Create(APIConstants.URI.APIURL + query);
                apiRequest.Method = APIConstants.URI.APIRequestMethod;
                apiRequest.Accept = APIConstants.URI.APIRequestAccept;

                log.Info("[" + DateTime.Now + "] - Sending request to API.\nDetails: " + apiRequest.RequestUri);

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
                //Logging magic!
                log.Error("[" + DateTime.Now + "] - Error Encountered in [XIVDBClient.Query]\nDetails: " + ex.Message +
                    "\n\nInner Details: " +
                    (ex.InnerException.Message == null ? "No Data..." : ex.InnerException.Message));
                return string.Empty;
            }
            finally
            {
                //Clean up variables
                if (reader != null) reader.Dispose();
                if (apiResponse != null) apiResponse.Dispose();

                log.Info("[" + DateTime.Now + "] - Response received from API. Performing cleanup...");
            }
        }
    }
}
