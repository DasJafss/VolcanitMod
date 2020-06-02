using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Weapons.Meele
{
	public class StarshadeSlicer : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Starshade Slicer");
		}

		public override void SetDefaults() 
		{
			item.damage = 25;
			item.melee = true;
			item.width = 38;
			item.height = 42;
			item.useTime = 25;
			item.useAnimation = 25;
			item.crit = 6;
			item.useStyle = 3;
			item.knockBack = 10;
			item.value = 10000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
	}
}