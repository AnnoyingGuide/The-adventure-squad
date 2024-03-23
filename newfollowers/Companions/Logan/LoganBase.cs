using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Terraria.Audio;
using System.Collections.Generic;
using terraguardians;

namespace newfollowers.Companions
{
    public class LoganBase : TerrarianBase
    {
        public override string Name => "Logan";
        public override string Description => "The fighter of the group when they get in danger he is the first to fight.";
        public override int Age => 18;
        public override Genders Gender => Genders.Male;
        public override float AccuracyPercent => 0.90f;
		public override CompanionGroup GetCompanionGroup => MainMod.newGroup;
        protected override CompanionDialogueContainer GetDialogueContainer => new Logan.LoganDialogues();
        protected override TerrarianCompanionInfo SetTerrarianCompanionInfo
        {
            get
            {
                return new TerrarianCompanionInfo()
                {
                    HairStyle = 54,
                    SkinVariant = 1,
                    HairColor = new Color(139, 69, 19),
                    EyeColor = new Color(0, 0, 0),
                    SkinColor = new Color(255, 204, 153),
                    ShirtColor = new Color(0, 0, 0),
                    UndershirtColor = new Color(153, 153, 0),
                    PantsColor = new Color(0, 204, 153),
                    ShoesColor = new Color(0, 0, 0)
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