using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.Audio;
using System.Collections.Generic;
using terraguardians;

namespace newfollowers.Companions
{
    public class HeroBase : TerrarianBase
    {
        public override string Name => "Hero";
        public override string Description => "He gets his name from his favorite sandwich. He's always ready to kick some butt";
        public override int Age => 19;
        public override Genders Gender => Genders.Male;
        public override float AccuracyPercent => 0.90f;
		public override CompanionGroup GetCompanionGroup => MainMod.newGroup;
        protected override CompanionDialogueContainer GetDialogueContainer => new Hero.HeroDialogues();
        protected override TerrarianCompanionInfo SetTerrarianCompanionInfo
        {
            get
            {
                return new TerrarianCompanionInfo()
                {
                    HairStyle = 0,
                    SkinVariant = 3,
                    HairColor = new Color(139, 69, 19),
                    EyeColor = new Color(0, 0, 0),
                    SkinColor = new Color(255, 204, 153),
                    ShirtColor = new Color(51, 51, 255),
                    UndershirtColor = new Color(0, 0, 255),
                    PantsColor = new Color(51, 53, 255),
                    ShoesColor = new Color(139, 69, 19)
                };
            }
        }
        public override void InitialInventory(out InitialItemDefinition[] InitialInventoryItems, ref InitialItemDefinition[] InitialEquipments)
        {
            InitialInventoryItems = new InitialItemDefinition[]
            {
                new InitialItemDefinition(ItemID.WoodenSword),
            };
        }
    }
}