using Terraria.ModLoader;
using terraguardians;

namespace newfollowers
{
	public class MainMod : Mod
	{
		public static Groups.NewGroup newGroup; //Custom companion group, so you can distinguish companions of a certain type by their group.

		public override void Load()
		{
			newGroup = new Groups.NewGroup(); //Creating the companion group, so I can assign it to companions.
		}

		public override void Unload()
		{
			newGroup = null;
		}

		public override void PostSetupContent()
		{
			terraguardians.MainMod.AddCompanionDB(new NewContainer(), this); //Adding the companion container I made to the companion database. That will control the companions list of the mod. Check DigimonContainer.cs.
		}
	}
}