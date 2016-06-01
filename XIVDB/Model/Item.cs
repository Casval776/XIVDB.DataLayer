using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XIVDB.Model
{
    public class Item
    {
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("help")]
        public string Help { get; set; }
        [JsonProperty("noun")]
        public string Noun { get; set; }
        [JsonProperty("plural")]
        public string Plural { get; set; }
        [JsonProperty("class_job_category")]
        public int ClassJobCategory { get; set; }
        [JsonProperty("max_quantity")]
        public int MaxQuantity { get; set; }
        [JsonProperty("action")]
        public int Action { get; set; }
        [JsonProperty("level_equip")]
        public int LevelEquip { get; set; }
        [JsonProperty("level_item")]
        public int LevelItem { get; set; }
        [JsonProperty("rarity")]
        public int Rarity { get; set; }
        [JsonProperty("hq")]
        public bool HQ { get; set; }
        [JsonProperty("special_bonus_id")]
        public int SpecialBonusId { get; set; }
        [JsonProperty("series_id")]
        public int SeriesId { get; set; }
        [JsonProperty("slot")]
        public int Slot { get; set; }
        [JsonProperty("slot_equip")]
        public int SlotEquip { get; set; }
        [JsonProperty("kind_id")]
        public int KindId { get; set; }
        [JsonProperty("category_id")]
        public int CategoryId { get; set; }
        [JsonProperty("price")]
        public int Price { get; set; }
        [JsonProperty("price_min")]
        public int PriceMin { get; set; }
        [JsonProperty("price_sell")]
        public int PriceSell { get; set; }
        [JsonProperty("price_sell_hq")]
        public int PriceSellHQ { get; set; }
        [JsonProperty("mirage_item_id")]
        public int MirageItemId { get; set; }
        [JsonProperty("icon_local")]
        public int IconLocal { get; set; }
        [JsonProperty("icon_lodestone")]
        public string IconLodestone { get; set; }
        [JsonProperty("icon_lodestone_hq")]
        public string IconLodestoneHQ { get; set; }
        [JsonProperty("salvage")]
        public int Salvage { get; set; }
        [JsonProperty("materia_slots")]
        public int MateriaSlots { get; set; }
        [JsonProperty("materialize_type")]
        public string MaterializeType { get; set; }
        [JsonProperty("lodestone_type")]
        public string LodestoneType { get; set; }
        [JsonProperty("lodestone_id")]
        public string LodestoneId { get; set; }
        [JsonProperty("sort_id")]
        public int SortId { get; set; }
        [JsonProperty("is_unique")]
        public bool IsUnique { get; set; }
        [JsonProperty("is_untradable")]
        public bool IsUntradable { get; set; }
        [JsonProperty("is_legacy")]
        public bool IsLegacy { get; set; }
        [JsonProperty("is_dated")]
        public bool IsDated { get; set; }
        [JsonProperty("is_crestable")]
        public bool IsCrestable { get; set; }
        [JsonProperty("is_desynthesizable")]
        public bool IsDesynthesizable { get; set; }
        [JsonProperty("is_projectable")]
        public bool IsProjectable { get; set; }
        [JsonProperty("is_dyeable")]
        public bool IsDyeable { get; set; }
        [JsonProperty("is_convertible")]
        public bool IsConvertible { get; set; }
        [JsonProperty("is_reducible")]
        public bool IsReducible { get; set; }
        [JsonProperty("repair_class_id")]
        public int RepairClassId { get; set; }
        [JsonProperty("repair_item_id")]
        public int RepairItemId { get; set; }
        [JsonProperty("repair_cost")]
        public int RepairCost { get; set; }
        [JsonProperty("reducible_class_id")]
        public int ReducibleClassId { get; set; }
        [JsonProperty("reducible_level")]
        public int ReducibleLevel { get; set; }
        [JsonProperty("flag_params")]
        public bool FlagParams { get; set; }
        [JsonProperty("flag_params_count")]
        public int FlagParamsCount { get; set; }
        [JsonProperty("flag_class_job")]
        public bool FlagClassJob { get; set; }
        [JsonProperty("flag_class_job_count")]
        public int FlagClassJobCount { get; set; }
        [JsonProperty("flag_instance")]
        public bool FlagInstance { get; set; }
        [JsonProperty("flag_instance_count")]
        public int FlagInstanceCount { get; set; }
        [JsonProperty("flag_instance_chest")]
        public int FlagInstanceChest { get; set; }
        [JsonProperty("flag_instance_chest_count")]
        public int FlagInstanceChestCount { get; set; }
        [JsonProperty("flag_instance_reward")]
        public bool FlagInstanceReward { get; set; }
        [JsonProperty("flag_instance_reward_count")]
        public int FlagInstanceRewardCount { get; set; }
        [JsonProperty("flag_quest")]
        public bool FlagQuest { get; set; }
        [JsonProperty("flag_quest_count")]
        public int FlagQuestCount { get; set; }
        [JsonProperty("flag_enemy")]
        public bool FlagEnemy { get; set; }
        [JsonProperty("flag_enemy_count")]
        public int FlagEnemyCount { get; set; }
        [JsonProperty("flag_recipe")]
        public bool FlagRecipe { get; set; }
        [JsonProperty("flag_recipe_count")]
        public int FlagRecipeCount { get; set; }
        [JsonProperty("flag_craftable")]
        public bool FlagCraftable { get; set; }
        [JsonProperty("flag_craftable_count")]
        public int FlagCraftableCount { get; set; }
        [JsonProperty("flag_shop")]
        public bool FlagShop { get; set; }
        [JsonProperty("flag_shop_count")]
        public int FlagShopCount { get; set; }
        [JsonProperty("flag_gathering")]
        public bool FlagGathering { get; set; }
        [JsonProperty("flag_gathering_count")]
        public int FlagGatheringCount { get; set; }
        [JsonProperty("flag_achievement")]
        public bool FlagAchievement { get; set; }
        [JsonProperty("flag_achievement_count")]
        public int FlagAchievementCount { get; set; }
        [JsonProperty("updated_libra")]
        public DateTime UpdatedLibra { get; set; }
        [JsonProperty("updated_official")]
        public DateTime UpdatedOfficial { get; set; }
        [JsonProperty("parsed_lodestone")]
        public bool ParsedLodestone { get; set; }
        [JsonProperty("parsed_lodestone_time")]
        public DateTime ParsedLodestoneTime { get; set; }
        [JsonProperty("patch")]
        public int Patch { get; set; }
        [JsonProperty("category_name")]
        public string CategoryName { get; set; }
        [JsonProperty("category_patch")]
        public int CategoryPatch { get; set; }
        [JsonProperty("kind_name")]
        public string KindName { get; set; }
        [JsonProperty("kind_patch")]
        public int KindPatch { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("url_xivdb")]
        public string UrlXivdb { get; set; }
        [JsonProperty("url_lodestone")]
        public string UrlLodestone { get; set; }
        [JsonProperty("color")]
        public string Color { get; set; }
        [JsonProperty("icon_size")]
        public int IconSize { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("icon_hq")]
        public string IconHQ { get; set; }
    }
}
