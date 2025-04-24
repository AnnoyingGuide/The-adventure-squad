using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.Audio;
using System.Collections.Generic;
using terraguardians;

namespace newfollowers.Companions
{
    public class NathanBase : TerrarianBase
    {
        public override string Name => "Nathan";
        public override string Description => "The owner of the adventure squad. May also be a dimension hopper.";
        public override int Age => 20;
        public override Genders Gender => Genders.Male;
        public override float AccuracyPercent => 1.00f;
		public override byte TriggerPercent => 100;
		public override CompanionGroup GetCompanionGroup => MainMod.newGroup;
		public override SoundStyle HurtSound => SoundID.PlayerHit;
		public override SoundStyle DeathSound => SoundID.PlayerKilled;
        protected override CompanionDialogueContainer GetDialogueContainer => new Nathan.NathanDialogues();
		protected override FriendshipLevelUnlocks SetFriendshipUnlocks => new FriendshipLevelUnlocks(){ MoveInUnlock = 0, VisitUnlock = 0, FollowerUnlock = 0, MountUnlock = 0, ControlUnlock = 0 };
        protected override TerrarianCompanionInfo SetTerrarianCompanionInfo
        {
            get
            {
                return new TerrarianCompanionInfo()
                {
                    HairStyle = 30,
                    SkinVariant = 0,
                    HairColor = new Color(139, 69, 19),
                    EyeColor = new Color(0, 0, 0),
                    SkinColor = new Color(255, 204, 153),
                    ShirtColor = new Color(0, 153, 76),
                    UndershirtColor = new Color(0, 102, 57),
                    PantsColor = new Color(0, 76, 153),
                    ShoesColor = new Color(102, 102, 0)
                };
            }
        }
        public override void InitialInventory(out InitialItemDefinition[] InitialInventoryItems, ref InitialItemDefinition[] InitialEquipments)
        {
            InitialInventoryItems = new InitialItemDefinition[]
            {
                new InitialItemDefinition(ItemID.WoodenSword),
				new InitialItemDefinition(ItemID.BabyBirdStaff),
				new InitialItemDefinition(ItemID.HealingPotion, 5)
            };
        }
    }
}