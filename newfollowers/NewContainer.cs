using Terraria.ModLoader;
using terraguardians;
using newfollowers.Companions;

namespace newfollowers
{
    public class NewContainer : CompanionContainer //Must inherit CompanionContainer
    {
        public const uint Nathan = 0;
		public const uint Logan = 1;
		public const uint Hero = 2;

        public override CompanionBase GetCompanionDB(uint ID) //This overrideable method will be used to get the companion base infos. Use each ID for different companions as you seem fit.
        {
            switch(ID)
            {
                case Nathan:
                    return new NathanBase();
				case Logan:
                    return new LoganBase();
				case Hero:
                    return new HeroBase();
            }
            return base.GetCompanionDB(ID);
        }
    }
}