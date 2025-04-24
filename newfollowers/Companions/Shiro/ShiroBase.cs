using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.Audio;
using System.Collections.Generic;
using terraguardians;

namespace newfollowers.Companions
{
    public class ShiroBase : TerrarianBase
    {
        public override string Name => "Shiro";
        public override string Description => "A cat turned into a Terrarian by strange magic.\nShe still has her signature white look.";
        public override int Age => 28;
        public override Genders Gender => Genders.Female;
        public override float AccuracyPercent => 1.00f;
		public override byte TriggerPercent => 100;
		public override CompanionGroup GetCompanionGroup => MainMod.newGroup;
		public override SoundStyle HurtSound => SoundID.FemaleHit;
		public override SoundStyle DeathSound => SoundID.PlayerKilled;
		public override bool IsNocturnal => true;
        protected override CompanionDialogueContainer GetDialogueContainer => new Shiro.ShiroDialogues();
		protected override FriendshipLevelUnlocks SetFriendshipUnlocks => new FriendshipLevelUnlocks(){ MoveInUnlock = 0, VisitUnlock = 0, FollowerUnlock = 0, MountUnlock = 0, ControlUnlock = 0 };
        protected override TerrarianCompanionInfo SetTerrarianCompanionInfo
        {
            get
            {
                return new TerrarianCompanionInfo()
                {
                    HairStyle = 133,
                    SkinVariant = 2,
                    HairColor = new Color(255, 255, 255),
                    EyeColor = new Color(0, 0, 0),
                    SkinColor = new Color(255, 255, 255),
                    ShirtColor = new Color(255, 255, 255),
                    UndershirtColor = new Color(255, 255, 255),
                    PantsColor = new Color(255, 255, 255),
                    ShoesColor = new Color(255, 255, 255)
                };
            }
        }
        public override void InitialInventory(out InitialItemDefinition[] InitialInventoryItems, ref InitialItemDefinition[] InitialEquipments)
        {
            InitialInventoryItems = new InitialItemDefinition[]
            {
                new InitialItemDefinition(ItemID.WoodenBow),
				new InitialItemDefinition(ItemID.WoodenArrow, 500),
				new InitialItemDefinition(ItemID.HealingPotion, 5)
            };
        }
    }
}