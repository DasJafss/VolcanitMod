using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Weapons.Melee
{
	public class Pickanch : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Pickanch");
			Tooltip.SetDefault("An anchor and a pickaxe had a baby.");
		}

		public override void SetDefaults() 
		{
			item.damage = 20;
			item.melee = true;
			item.width = 32;
			item.pick = 100;
			item.height = 32;
			item.useTime = 10;
			item.useAnimation = 10;
			item.crit = -4;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
	}
}