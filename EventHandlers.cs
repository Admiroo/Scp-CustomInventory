using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using MEC;
using PlayerRoles;
using Random = System.Random;

namespace CustomInventory
{
    public class EventHandlers
    {
        public void OnPlayerSpawn(SpawnedEventArgs pl)
        {
            if (pl.Player.Role == RoleTypeId.ClassD)
            {
                for(int c = 0; c < CustomInventory.Instance.Config.CustomInventoryItemsClassD.Count; c++) {
                    Random rand = new Random();
                    int i = rand.Next(0, 101);
                    if (i <= CustomInventory.Instance.Config.Chancesclassd[c])
                    {
                        pl.Player.AddItem(CustomInventory.Instance.Config.CustomInventoryItemsClassD[c]);
                    }
                }
            }
            else if (pl.Player.Role == RoleTypeId.Scientist)
            {
                for (int c = 0; c < CustomInventory.Instance.Config.CustomInventoryItemsScientist.Count; c++)
                {
                    Random rand = new Random();
                    int i = rand.Next(0, 101);
                    if (i <= CustomInventory.Instance.Config.Chancesscientists[c])
                    {
                        pl.Player.AddItem(CustomInventory.Instance.Config.CustomInventoryItemsScientist[c]);
                    }
                }
            }
            else if (pl.Player.Role == RoleTypeId.FacilityGuard)
            {
                for (int c = 0; c < CustomInventory.Instance.Config.CustomInventoryItemsfacilityguard.Count; c++)
                {
                    Random rand = new Random();
                    int i = rand.Next(0, 101);
                    if (i <= CustomInventory.Instance.Config.Chancesfacilityguard[c])
                    {
                        pl.Player.AddItem(CustomInventory.Instance.Config.CustomInventoryItemsfacilityguard[c]);
                    }
                }
            }
            else if (pl.Player.Role == RoleTypeId.NtfCaptain)
            {
                for (int c = 0; c < CustomInventory.Instance.Config.CustomInventoryItemsntfCaptain.Count; c++)
                {
                    Random rand = new Random();
                    int i = rand.Next(0, 101);
                    if (i <= CustomInventory.Instance.Config.ChancesntfCaptain[c])
                    {
                        pl.Player.AddItem(CustomInventory.Instance.Config.CustomInventoryItemsntfCaptain[c]);
                    }
                }
            }
            else if (pl.Player.Role == RoleTypeId.NtfSergeant)
            {
                for (int c = 0; c < CustomInventory.Instance.Config.CustomInventoryItemsntfseargent.Count; c++)
                {
                    Random rand = new Random();
                    int i = rand.Next(0, 101);
                    if (i <= CustomInventory.Instance.Config.Chancesntfseargent[c])
                    {
                        pl.Player.AddItem(CustomInventory.Instance.Config.CustomInventoryItemsntfseargent[c]);
                    }
                }
            }
            else if (pl.Player.Role == RoleTypeId.NtfPrivate)
            {
                for (int c = 0; c < CustomInventory.Instance.Config.CustomInventoryItemsntfprivate.Count; c++)
                {
                    Random rand = new Random();
                    int i = rand.Next(0, 101);
                    if (i <= CustomInventory.Instance.Config.Chancesntfprivate[c])
                    {
                        pl.Player.AddItem(CustomInventory.Instance.Config.CustomInventoryItemsntfprivate[c]);
                    }
                }
            }
            else if (pl.Player.Role == RoleTypeId.NtfSpecialist)
            {
                for (int c = 0; c < CustomInventory.Instance.Config.CustomInventoryItemsntfSpecialist.Count; c++)
                {
                    Random rand = new Random();
                    int i = rand.Next(0, 101);
                    if (i <= CustomInventory.Instance.Config.ChancesntfSpecialist[c])
                    {
                        pl.Player.AddItem(CustomInventory.Instance.Config.CustomInventoryItemsntfSpecialist[c]);
                    }
                }
            }
            else if (pl.Player.Role == RoleTypeId.ChaosConscript)
            {
                for (int c = 0; c < CustomInventory.Instance.Config.CustomInventoryItemschaosconscript.Count; c++)
                {
                    Random rand = new Random();
                    int i = rand.Next(0, 101);
                    if (i <= CustomInventory.Instance.Config.Chanceschaosconscript[c])
                    {
                        pl.Player.AddItem(CustomInventory.Instance.Config.CustomInventoryItemschaosconscript[c]);
                    }
                }
            }
            else if (pl.Player.Role == RoleTypeId.ChaosRepressor)
            {
                for (int c = 0; c < CustomInventory.Instance.Config.CustomInventoryItemschaosrepressor.Count; c++)
                {
                    Random rand = new Random();
                    int i = rand.Next(0, 101);
                    if (i <= CustomInventory.Instance.Config.Chanceschaosrepressor[c])
                    {
                        pl.Player.AddItem(CustomInventory.Instance.Config.CustomInventoryItemschaosrepressor[c]);
                    }
                }
            }
            else if (pl.Player.Role == RoleTypeId.ChaosRifleman)
            {
                for (int c = 0; c < CustomInventory.Instance.Config.CustomInventoryItemschaosrifleman.Count; c++)
                {
                    Random rand = new Random();
                    int i = rand.Next(0, 101);
                    if (i <= CustomInventory.Instance.Config.Chanceschaosrifleman[c])
                    {
                        pl.Player.AddItem(CustomInventory.Instance.Config.CustomInventoryItemschaosrifleman[c]);
                    }
                }
            }
            else if (pl.Player.Role == RoleTypeId.ChaosMarauder)
            {
                for (int c = 0; c < CustomInventory.Instance.Config.CustomInventoryItemschaosmarauder.Count; c++)
                {
                    Random rand = new Random();
                    int i = rand.Next(0, 101);
                    if (i <= CustomInventory.Instance.Config.Chanceschaosmarauder[c])
                    {
                        pl.Player.AddItem(CustomInventory.Instance.Config.CustomInventoryItemschaosmarauder[c]);
                    }
                }
            }
        }

        public void OnRagdollSpawn(SpawnedRagdollEventArgs ev)
        {
            Timing.CallDelayed(60, () =>
            {
                ev.Ragdoll.Destroy();
            });
        }
    }
}
