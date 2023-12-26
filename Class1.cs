using System;
using Exiled.API.Enums;
using Exiled.API.Features;
using Player = Exiled.Events.Handlers.Player;
using Server = Exiled.Events.Handlers.Server;

namespace CustomInventory
{
    public class CustomInventory : Plugin<Config>
    {
        public static CustomInventory Instance { get; private set; }
        public override string Name => "CustomInvetory";
        public override string Author => "Admiro";
        public override string Prefix => "CI";
        public override Version Version => new Version(1, 1, 0);
        public override Version RequiredExiledVersion => new Version(8, 4, 3);
        public override PluginPriority Priority => PluginPriority.Medium;
        private EventHandlers player;
        private EventHandlers server;

        public override void OnEnabled()
        {
            Instance = this;
            RegisterEvents();
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            UnRegisterEvents();
            base.OnDisabled();
        }

        public void RegisterEvents()
        {
            player = new EventHandlers();
            server = new EventHandlers();

            Player.Spawned += player.OnPlayerSpawn;
            Player.SpawnedRagdoll += player.OnRagdollSpawn;
        }
        public void UnRegisterEvents()
        {
            Player.Spawned -= player.OnPlayerSpawn;
            Player.SpawnedRagdoll -= player.OnRagdollSpawn;

            player = null;
            server = null;
        }
    }
}
