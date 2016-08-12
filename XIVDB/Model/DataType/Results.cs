
//-------------------------------------------------------
//
//      Copyright (c) 2016 All Rights Reserved
//          Daikun Industries LLC
//
//-------------------------------------------------------

using XIVDB.Model.DataType;

namespace XIVDB.Model.DataType
{
    /// <summary>
    /// Container Model for all IXIVDBObjects returned by the
    /// XIVDB API.
    /// </summary>
    public class Results
    {
        #region Properties
        public ResultList<Achievement> Achievements { get; set; }
        public ResultList<Action> Actions { get; set; }
        public ResultList<Emote> Emotes { get; set; }
        public ResultList<Enemy> Enemies { get; set; }
        public ResultList<Fate> FATEs { get; set; }
        public ResultList<Gathering> Gathering { get; set; }
        public ResultList<Instance> Instances { get; set; }
        public ResultList<Item> Items { get; set; }
        public ResultList<Leve> Leves { get; set; }
        public ResultList<Minion> Minions { get; set; }
        public ResultList<Mount> Mounts { get; set; }
        public ResultList<Npc> NPCs { get; set; }
        public ResultList<Place> Places { get; set; }
        public ResultList<Quest> Quests { get; set; }
        public ResultList<Recipe> Recipes { get; set; }
        public ResultList<Status> Statuses { get; set; }
        public ResultList<Title> Titles { get; set; }
        public ResultList<Weather> Weathers { get; set; }
        #endregion
    }
}
