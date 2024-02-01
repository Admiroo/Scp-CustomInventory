using Exiled.API.Interfaces;
using PlayerRoles;
using System.Collections.Generic;
using System.ComponentModel;

namespace CustomInventory
{
    public sealed class Config : IConfig
    {

        [Description("Wheter the plugin is Enabled or not.")]
        public bool IsEnabled { get; set; } = true;

        [Description("Whether or not debug messages should be shown in the console.")]
        public bool Debug { get; set; } = false;

        [Description("Custom Inventory items. You must add chances to each item in CustomInventaryChances")]
        public Dictionary<RoleTypeId, List<ItemType>> CustomInventoryList { get; set; } = new Dictionary<RoleTypeId, List<ItemType>>()
        {
            { RoleTypeId.ClassD, new List<ItemType>(){ ItemType.Coin }},
        };

        [Description("Chances each item has. 50 means 50%")]
        public Dictionary<RoleTypeId, int[]> CustomInventaryChances { get; set; } = new Dictionary<RoleTypeId, int[]>()
        { 
            { RoleTypeId.ClassD, new int[] { 75 }},
        };

        [Description("Classes to clear inventory (replace inventory completely)")]
        public List<RoleTypeId> ReplaceInventory { get; set; } = new List<RoleTypeId>()
        { 
            RoleTypeId.Tutorial,
        };

    }
}
