//-------------------------------------------------------
//
//      Copyright (c) 2016 All Rights Reserved
//          Daikun Industries LLC
//
//-------------------------------------------------------

using Newtonsoft.Json;
using System;
using XIVDB.Interfaces;

namespace XIVDB.Model
{
    /// <summary>
    /// Model class for Item data types
    /// </summary>
    public class Item : IXivdbObject
    {
        #region Properties
        [JsonProperty("id")]
        public int? Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("help")]
        public string Help { get; set; }
        [JsonProperty("noun")]
        public string Noun { get; set; }
        [JsonProperty("plural")]
        public string Plural { get; set; }
        [JsonProperty("class_job_category", NullValueHandling = NullValueHandling.Ignore)]
        public int? ClassJobCategory { get; set; }
        [JsonProperty("max_quantity", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxQuantity { get; set; }
        [JsonProperty("action", NullValueHandling = NullValueHandling.Ignore)]
        public int? Action { get; set; }
        [JsonProperty("level_equip", NullValueHandling = NullValueHandling.Ignore)]
        public int? LevelEquip { get; set; }
        [JsonProperty("level_item", NullValueHandling = NullValueHandling.Ignore)]
        public int? LevelItem { get; set; }
        [JsonProperty("rarity", NullValueHandling = NullValueHandling.Ignore)]
        public int? Rarity { get; set; }
        [JsonProperty("hq")]
        public bool? Hq { get; set; }
        [JsonProperty("special_bonus_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SpecialBonusId { get; set; }
        [JsonProperty("series_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SeriesId { get; set; }
        [JsonProperty("slot", NullValueHandling = NullValueHandling.Ignore)]
        public int? Slot { get; set; }
        [JsonProperty("slot_equip", NullValueHandling = NullValueHandling.Ignore)]
        public int? SlotEquip { get; set; }
        [JsonProperty("kind_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? KindId { get; set; }
        [JsonProperty("category_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? CategoryId { get; set; }
        [JsonProperty("price", NullValueHandling = NullValueHandling.Ignore)]
        public int? Price { get; set; }
        [JsonProperty("price_min", NullValueHandling = NullValueHandling.Ignore)]
        public int? PriceMin { get; set; }
        [JsonProperty("price_sell", NullValueHandling = NullValueHandling.Ignore)]
        public int? PriceSell { get; set; }
        [JsonProperty("price_sell_hq", NullValueHandling = NullValueHandling.Ignore)]
        public int? PriceSellHq { get; set; }
        [JsonProperty("mirage_item_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MirageItemId { get; set; }
        [JsonProperty("icon_local", NullValueHandling = NullValueHandling.Ignore)]
        public int? IconLocal { get; set; }
        [JsonProperty("icon_lodestone")]
        public string IconLodestone { get; set; }
        [JsonProperty("icon_lodestone_hq")]
        public string IconLodestoneHq { get; set; }
        [JsonProperty("salvage", NullValueHandling = NullValueHandling.Ignore)]
        public int? Salvage { get; set; }
        [JsonProperty("materia_slots", NullValueHandling = NullValueHandling.Ignore)]
        public int? MateriaSlots { get; set; }
        [JsonProperty("materialize_type")]
        public string MaterializeType { get; set; }
        [JsonProperty("lodestone_type")]
        public string LodestoneType { get; set; }
        [JsonProperty("lodestone_id")]
        public string LodestoneId { get; set; }
        [JsonProperty("sort_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? SortId { get; set; }
        [JsonProperty("is_unique")]
        public bool? IsUnique { get; set; }
        [JsonProperty("is_untradable")]
        public bool? IsUntradable { get; set; }
        [JsonProperty("is_legacy")]
        public bool? IsLegacy { get; set; }
        [JsonProperty("is_dated")]
        public bool? IsDated { get; set; }
        [JsonProperty("is_crestable")]
        public bool? IsCrestable { get; set; }
        [JsonProperty("is_desynthesizable")]
        public bool? IsDesynthesizable { get; set; }
        [JsonProperty("is_projectable")]
        public bool? IsProjectable { get; set; }
        [JsonProperty("is_dyeable")]
        public bool? IsDyeable { get; set; }
        [JsonProperty("is_convertible")]
        public bool? IsConvertible { get; set; }
        [JsonProperty("is_reducible")]
        public bool? IsReducible { get; set; }
        [JsonProperty("repair_class_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepairClassId { get; set; }
        [JsonProperty("repair_item_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepairItemId { get; set; }
        [JsonProperty("repair_cost", NullValueHandling = NullValueHandling.Ignore)]
        public int? RepairCost { get; set; }
        [JsonProperty("reducible_class_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReducibleClassId { get; set; }
        [JsonProperty("reducible_level", NullValueHandling = NullValueHandling.Ignore)]
        public int? ReducibleLevel { get; set; }
        [JsonProperty("flag_params")]
        public bool? FlagParams { get; set; }
        [JsonProperty("flag_params_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? FlagParamsCount { get; set; }
        [JsonProperty("flag_class_job")]
        public bool? FlagClassJob { get; set; }
        [JsonProperty("flag_class_job_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? FlagClassJobCount { get; set; }
        [JsonProperty("flag_instance")]
        public bool? FlagInstance { get; set; }
        [JsonProperty("flag_instance_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? FlagInstanceCount { get; set; }
        [JsonProperty("flag_instance_chest", NullValueHandling = NullValueHandling.Ignore)]
        public int? FlagInstanceChest { get; set; }
        [JsonProperty("flag_instance_chest_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? FlagInstanceChestCount { get; set; }
        [JsonProperty("flag_instance_reward")]
        public bool? FlagInstanceReward { get; set; }
        [JsonProperty("flag_instance_reward_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? FlagInstanceRewardCount { get; set; }
        [JsonProperty("flag_quest")]
        public bool? FlagQuest { get; set; }
        [JsonProperty("flag_quest_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? FlagQuestCount { get; set; }
        [JsonProperty("flag_enemy")]
        public bool? FlagEnemy { get; set; }
        [JsonProperty("flag_enemy_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? FlagEnemyCount { get; set; }
        [JsonProperty("flag_recipe")]
        public bool? FlagRecipe { get; set; }
        [JsonProperty("flag_recipe_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? FlagRecipeCount { get; set; }
        [JsonProperty("flag_craftable")]
        public bool? FlagCraftable { get; set; }
        [JsonProperty("flag_craftable_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? FlagCraftableCount { get; set; }
        [JsonProperty("flag_shop")]
        public bool? FlagShop { get; set; }
        [JsonProperty("flag_shop_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? FlagShopCount { get; set; }
        [JsonProperty("flag_gathering")]
        public bool? FlagGathering { get; set; }
        [JsonProperty("flag_gathering_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? FlagGatheringCount { get; set; }
        [JsonProperty("flag_achievement")]
        public bool? FlagAchievement { get; set; }
        [JsonProperty("flag_achievement_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? FlagAchievementCount { get; set; }
        [JsonProperty("updated_libra")]
        public DateTime? UpdatedLibra { get; set; }
        [JsonProperty("updated_official")]
        public DateTime? UpdatedOfficial { get; set; }
        [JsonProperty("parsed_lodestone")]
        public bool? ParsedLodestone { get; set; }
        [JsonProperty("parsed_lodestone_time")]
        public DateTime? ParsedLodestoneTime { get; set; }
        [JsonProperty("patch", NullValueHandling = NullValueHandling.Ignore)]
        public int? Patch { get; set; }
        [JsonProperty("category_name")]
        public string CategoryName { get; set; }
        [JsonProperty("category_patch", NullValueHandling = NullValueHandling.Ignore)]
        public int? CategoryPatch { get; set; }
        [JsonProperty("kind_name")]
        public string KindName { get; set; }
        [JsonProperty("kind_patch", NullValueHandling = NullValueHandling.Ignore)]
        public int? KindPatch { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("url_xivdb")]
        public string UrlXivdb { get; set; }
        [JsonProperty("url_lodestone")]
        public string UrlLodestone { get; set; }
        [JsonProperty("color")]
        public string Color { get; set; }
        [JsonProperty("icon_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? IconSize { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("icon_hq")]
        public string IconHq { get; set; }
        #endregion
    }
}
