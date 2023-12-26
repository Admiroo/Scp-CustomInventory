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

        [Description("Items to be given to class-d players when spawned")]
        public List<ItemType> CustomInventoryItemsClassD { get; set; } = new List<ItemType>()
        {
            ItemType.Coin
        };

        [Description("What chances of spawning each item has")]
        public int[] Chancesclassd { get; set; } = new int[]
        {
            75,
        };

        [Description("Items to give to scientists players when spawned")]
        public List<ItemType> CustomInventoryItemsScientist { get; set; } = new List<ItemType>()
        {
            ItemType.Coin
        };

        [Description("What chances of spawning each item has")]
        public int[] Chancesscientists { get; set; } = new int[]
        {
            75,
        };

        [Description("Items to give to ntfprivate players when spawned")]
        public List<ItemType> CustomInventoryItemsntfprivate { get; set; } = new List<ItemType>()
        {
            ItemType.Coin
        };

        [Description("What chances of spawning each item has")]
        public int[] Chancesntfprivate { get; set; } = new int[]
        {
            75,
        };

        [Description("Items to give to ntfseargent players when spawned")]
        public List<ItemType> CustomInventoryItemsntfseargent { get; set; } = new List<ItemType>()
        {
            ItemType.Coin
        };

        [Description("What chances of spawning each item has")]
        public int[] Chancesntfseargent { get; set; } = new int[]
        {
            75,
        };

        [Description("Items to give to ntfCaptain players when spawned")]
        public List<ItemType> CustomInventoryItemsntfCaptain { get; set; } = new List<ItemType>()
        {
            ItemType.Coin
        };

        [Description("What chances of spawning each item has")]
        public int[] ChancesntfCaptain { get; set; } = new int[]
        {
            75,
        };

        [Description("Items to give to ntfSpecialist players when spawned")]
        public List<ItemType> CustomInventoryItemsntfSpecialist { get; set; } = new List<ItemType>()
        {
            ItemType.Coin
        };

        [Description("What chances of spawning each item has")]
        public int[] ChancesntfSpecialist { get; set; } = new int[]
        {
            75,
        };

        [Description("Items to give to chaosrepressor players when spawned")]
        public List<ItemType> CustomInventoryItemschaosrepressor { get; set; } = new List<ItemType>()
        {
            ItemType.Coin
        };

        [Description("What chances of spawning each item has")]
        public int[] Chanceschaosrepressor   { get; set; } = new int[]
        {
            75,
        };

        [Description("Items to give to chaosmarauder players when spawned")]
        public List<ItemType> CustomInventoryItemschaosmarauder { get; set; } = new List<ItemType>()
        {
            ItemType.Coin
        };

        [Description("What chances of spawning each item has")]
        public int[] Chanceschaosmarauder { get; set; } = new int[]
        {
            75,
        };

        [Description("Items to give to chaosrifleman players when spawned")]
        public List<ItemType> CustomInventoryItemschaosrifleman { get; set; } = new List<ItemType>()
        {
            ItemType.Coin
        };

        [Description("What chances of spawning each item has")]
        public int[] Chanceschaosrifleman { get; set; } = new int[]
        {
            75,
        };

        [Description("Items to give to chaosconscript players when spawned")]
        public List<ItemType> CustomInventoryItemschaosconscript { get; set; } = new List<ItemType>()
        {
            ItemType.Coin
        };

        [Description("What chances of spawning each item has")]
        public int[] Chanceschaosconscript { get; set; } = new int[]
        {
            75,
        };

        [Description("Items to give to facilityguard players when spawned")]
        public List<ItemType> CustomInventoryItemsfacilityguard { get; set; } = new List<ItemType>()
        {
            ItemType.Coin
        };

        [Description("What chances of spawning each item has")]
        public int[] Chancesfacilityguard { get; set; } = new int[]
        {
            75,
        };
    }
}
