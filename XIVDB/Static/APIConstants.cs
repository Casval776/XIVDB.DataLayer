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

        /// <summary>
        /// Holds JSON Return Node Names constant values
        /// </summary>
        public struct ReturnNode
        {
            public const string Items = "items";
            public const string Quests = "quests";
            public const string Actions = "actions";
            public const string Achievements = "achievements";
            public const string Recipes = "recipes";
            public const string Instances = "instances";
            public const string FATEs = "fates";
            public const string Leves = "leves";
            public const string Places = "places";
            public const string Gathering = "gathering";
            public const string NPCs = "npcs";
            public const string Enemies = "enemies";
            public const string Emotes = "emotes";
            public const string Status = "status";
            public const string Titles = "titles";
            public const string Minions = "minions";
            public const string Mounts = "mounts";
            public const string Weather = "weather";
        }
    }
}
