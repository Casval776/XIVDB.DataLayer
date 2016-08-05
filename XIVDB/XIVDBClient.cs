
//-------------------------------------------------------
//
//      Copyright (c) 2016 All Rights Reserved
//          Daikun Industries LLC
//
//-------------------------------------------------------

using System;
using System.IO;
using System.Net;
using XIVDB.Enums;
using XIVDB.Model;
using XIVDB.Static;
using XIVDB.Helpers;
using Newtonsoft.Json;
using log4net;
using log4net.Config;
using XIVDB.Model.DataType;

namespace XIVDB
{
    public sealed class XivdbClient
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(XivdbClient));
        //Singleton Instance
        // ReSharper disable once InconsistentNaming
        private static readonly XivdbClient _instance = new XivdbClient();
        private XivdbClient()
        {
            XmlConfigurator.Configure();
            Log.Info("[" + DateTime.Now + "] - XIVDBClient instantiated.");
        }

        static XivdbClient()
        {

        }

        public static XivdbClient Instance
        {
            get
            {
                Log.Info("[" + DateTime.Now + "] - XIVDBClient Instance requested.");
                return _instance;
            }
        }

        public Results XivdbQuery(SearchType searchType, string query)
        {
            Log.Info("[" + DateTime.Now + "] - Beginning query on Query Type [" + searchType.ToString() + "] with params [" + query + "]");
            //For the time being, treat all queries as full text
            //This does not take search prefixes into account
            //Query XIVDB API
            var response = Query(RequestHelper.PrepareQueryString(searchType, query));

            //Start deserializing objects into return types
            var deserializedResponse = JsonConvert.DeserializeObject<dynamic>(response);

            //Instantiate result container
            var results = new Results();

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
                        case ApiConstants.ReturnNode.Achievements:
                            results.Achievements = ResponseHelper.Deserialize<Achievement>(deserializedResponse.achievements);
                            break;
                        case ApiConstants.ReturnNode.Actions:
                            results.Actions = ResponseHelper.Deserialize<Model.Action>(deserializedResponse.actions);
                            break;
                        case ApiConstants.ReturnNode.Emotes:
                            results.Emotes = ResponseHelper.Deserialize<Emote>(deserializedResponse.emotes);
                            break;
                        case ApiConstants.ReturnNode.Enemies:
                            results.Enemies = ResponseHelper.Deserialize<Enemy>(deserializedResponse.enemies);
                            break;
                        case ApiConstants.ReturnNode.Fates:
                            results.FATEs = ResponseHelper.Deserialize<FATE>(deserializedResponse.fates);
                            break;
                        case ApiConstants.ReturnNode.Gathering:
                            results.Gathering = ResponseHelper.Deserialize<Gathering>(deserializedResponse.gathering);
                            break;
                        case ApiConstants.ReturnNode.Instances:
                            results.Instances = ResponseHelper.Deserialize<Instance>(deserializedResponse.instances);
                            break;
                        case ApiConstants.ReturnNode.Items:
                            results.Items = ResponseHelper.Deserialize<Item>(deserializedResponse.items);
                            break;
                        case ApiConstants.ReturnNode.Leves:
                            results.Leves = ResponseHelper.Deserialize<Leve>(deserializedResponse.leves);
                            break;
                        case ApiConstants.ReturnNode.Minions:
                            results.Minions = ResponseHelper.Deserialize<Minion>(deserializedResponse.minions);
                            break;
                        case ApiConstants.ReturnNode.Mounts:
                            results.Mounts = ResponseHelper.Deserialize<Mount>(deserializedResponse.mounts);
                            break;
                        case ApiConstants.ReturnNode.Npcs:
                            results.NPCs = ResponseHelper.Deserialize<NPC>(deserializedResponse.npcs);
                            break;
                        case ApiConstants.ReturnNode.Places:
                            results.Places = ResponseHelper.Deserialize<Place>(deserializedResponse.places);
                            break;
                        case ApiConstants.ReturnNode.Quests:
                            results.Quests = ResponseHelper.Deserialize<Quest>(deserializedResponse.quests);
                            break;
                        case ApiConstants.ReturnNode.Recipes:
                            results.Recipes = ResponseHelper.Deserialize<Recipe>(deserializedResponse.recipes);
                            break;
                        case ApiConstants.ReturnNode.Status:
                            results.Statuses = ResponseHelper.Deserialize<Status>(deserializedResponse.status);
                            break;
                        case ApiConstants.ReturnNode.Titles:
                            results.Titles = ResponseHelper.Deserialize<Title>(deserializedResponse.titles);
                            break;
                        case ApiConstants.ReturnNode.Weather:
                            results.Weathers = ResponseHelper.Deserialize<Weather>(deserializedResponse.weather);
                            break;
                        //Default case in case a new return type is introduced
                        default: Log.Info("[" + DateTime.Now + "] - New item type introduced: " + nodeType);
                            break;
                    }
                }
                Log.Info("[" + DateTime.Now + "] - Response deserialization finished");
            }
            catch (Exception ex)
            {
                //Do nothing
                Log.Error("[" + DateTime.Now + "] - Error Encountered in [XIVDBClient.XIVDBQuery]\nDetails: " + ex.Message + 
                    "\n\nInner Details: " + 
                    (ex.InnerException.Message));
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
                var apiRequest = (HttpWebRequest)WebRequest.Create(ApiConstants.Uri.ApiUrl + query);
                apiRequest.Method = ApiConstants.Uri.ApiRequestMethod;
                apiRequest.Accept = ApiConstants.Uri.ApiRequestAccept;

                Log.Info("[" + DateTime.Now + "] - Sending request to API.\nDetails: " + apiRequest.RequestUri);

                string response;
                apiResponse = (HttpWebResponse)apiRequest.GetResponse();
                // ReSharper disable once AssignNullToNotNullAttribute
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
                Log.Error("[" + DateTime.Now + "] - Error Encountered in [XIVDBClient.Query]\nDetails: " + ex.Message +
                    "\n\nInner Details: " +
                    (ex.InnerException.Message));
                return string.Empty;
            }
            finally
            {
                //Clean up variables
                reader?.Dispose();
                apiResponse?.Dispose();

                Log.Info("[" + DateTime.Now + "] - Response received from API. Performing cleanup...");
            }
        }
    }
}
