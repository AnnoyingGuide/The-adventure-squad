using Terraria.ModLoader;
using Terraria;
using terraguardians;

namespace newfollowers.Items
{
    public class grabbag2 : ModItem
    {
        private bool UseItem(Player player)
        {
            return player.whoAmI == Main.myPlayer && !PlayerMod.PlayerHasCompanion(player, 1, this.Mod.Name)  //Player doesn't have Gaomon in their companion list
            && 
            !terraguardians.WorldMod.HasCompanionNPCSpawned(1, this.Mod.Name) //Gaomon is not a companion npc in the world.
             && 
            !terraguardians.WorldMod.HasMetCompanion(1, this.Mod.Name); //Gaomon has never been met in this world.
        }

        public override bool CanUseItem(Player player)
        {
            if (UseItem(player))
            {
                //This script makes so the item spawns Gaomon on the player position.
                Companion tg = 
				terraguardians.WorldMod.SpawnCompanionNPC(player.Bottom, NewContainer.Logan, Mod.Name);
                Main.NewText("After opening the bag someone fell out");
                Item.SetDefaults(0);
                return true;
            }
            Main.NewText("You've already let them out of this bag");
            return false;
        }

        public override void SetDefaults()
        {
            Item.UseSound = Terraria.ID.SoundID.Item4;
            Item.useStyle = 4;
            Item.useTurn = false;
            Item.useAnimation = 5;
            Item.useTime = 5;
            Item.maxStack = 1;
            Item.consumable = true;
            Item.value = Terraria.Item.buyPrice(0, 1);
            Item.width = 22;
            Item.height = 22;
            Item.rare = 2;
            Item.value = 1;
        }
    }
}
