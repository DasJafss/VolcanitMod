using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items
{
	public class PainStarDX : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Pain Star DX");
			Tooltip.SetDefault("It does a thing!");
		}

		public override void SetDefaults() 
		{
			item.damage = 25;
			item.melee = true;
			item.width = 42;
			item.height = 36;
			item.useTime = 20;
			item.useAnimation = 20;
			item.crit = 91;
			item.useStyle = 4;
			item.knockBack = 100;
			item.value = 10000;
			item.rare = 3;
			item.UseSound = SoundID.Item29;
			item.autoReuse = true;
		}
	}
}