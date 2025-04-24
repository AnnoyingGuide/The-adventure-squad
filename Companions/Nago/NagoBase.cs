using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.Audio;
using System.Collections.Generic;
using terraguardians;

namespace newfollowers.Companions
{
    public class NagoBase : TerrarianBase
    {
        public override string Name => "Nago";
        public override string Description => "Apparently a cat cursed into a Terrarian.\nShiro's love interest, maybe.";
        public override int Age => 28;
        public override Genders Gender => Genders.Male;
        public override float AccuracyPercent => 1.00f;
		public override byte TriggerPercent => 100;
		public override bool IsNocturnal => true;
		public override CompanionGroup GetCompanionGroup => MainMod.newGroup;
		public override SoundStyle HurtSound => SoundID.PlayerHit;
		public override SoundStyle DeathSound => SoundID.PlayerKilled;
        protected override CompanionDialogueContainer GetDialogueContainer => new Nago.NagoDialogues();
		protected override FriendshipLevelUnlocks SetFriendshipUnlocks => new FriendshipLevelUnlocks(){ MoveInUnlock = 0, VisitUnlock = 0, FollowerUnlock = 0, MountUnlock = 0, ControlUnlock = 0 };
        protected override TerrarianCompanionInfo SetTerrarianCompanionInfo
        {
            get
            {
                return new TerrarianCompanionInfo()
                {
                    HairStyle = 76,
                    SkinVariant = 0,
                    HairColor = new Color(40, 40, 40),
                    EyeColor = new Color(0, 0, 0),
                    SkinColor = new Color(245, 220, 190),
                    ShirtColor = new Color(255, 255, 255),
                    UndershirtColor = new Color(80, 60, 50),
                    PantsColor = new Color(245, 220, 190),
                    ShoesColor = new Color(40, 40, 40)
                };
            }
        }
        public override void InitialInventory(out InitialItemDefinition[] InitialInventoryItems, ref InitialItemDefinition[] InitialEquipments)
        {
            InitialInventoryItems = new InitialItemDefinition[]
            {
                new InitialItemDefinition(ItemID.CopperShortsword),
				new InitialItemDefinition(ItemID.HealingPotion, 10)
            };
        }
    }
}