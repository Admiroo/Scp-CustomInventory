using Exiled.API.Features;
using Exiled.API.Features.Items;
using Exiled.API.Features.Pickups;
using Exiled.Events.EventArgs.Player;
using MEC;
using PlayerRoles;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace CustomInventory
{
    public class EventHandlers
    {
        public void OnPlayerSpawn(SpawnedEventArgs pl)
        {
            if (CustomInventory.Instance.Config.ReplaceInventory.Contains(pl.Player.Role))
            {
                pl.Player.ClearInventory();
            }

            if (!CustomInventory.Instance.Config.CustomInventoryList.ContainsKey(pl.Player.Role)) { return; }
            if (!CustomInventory.Instance.Config.CustomInventaryChances.ContainsKey(pl.Player.Role)) { Log.Error($"Chances of RoleTypeId {pl.Player.Role} not found in CustomInventoryChances"); return; }

            for (int i = 0; i < CustomInventory.Instance.Config.CustomInventoryList[pl.Player.Role].Count; i++)
            {
                int c = Random.Range(1, 101);
                if (c <= CustomInventory.Instance.Config.CustomInventaryChances[pl.Player.Role][i])
                {
                    pl.Player.AddItem(CustomInventory.Instance.Config.CustomInventoryList[pl.Player.Role][i]);
                }
            }
        }
    }
}
