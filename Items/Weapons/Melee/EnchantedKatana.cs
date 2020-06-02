using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Weapons.Melee
{
	public class EnchantedKatana : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Enchanted Katana");
			Tooltip.SetDefault("It has a small Made-In-China logo on the bottom...");
		}

		public override void SetDefaults() 
		{
			item.damage = 45;
			item.melee = true;
			item.width = 48;
			item.height = 48;
			item.useTime = 12;
			item.useAnimation = 12;
			item.crit = 6;
			item.useStyle = 1;
			item.knockBack = 1;
			item.value = 100000;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
	}
}