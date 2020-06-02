using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Tools.Hammers
{
	public class CursedHammer : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Cursed Hammer");
		}

		public override void SetDefaults() 
		{
			item.damage = 43;
			item.melee = true;
			item.width = 48;
			item.hammer = 240;
			item.height = 48;
			item.useTime = 15;
			item.useAnimation = 15;
			item.crit = 3;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 100000;
			item.rare = 9;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CursedBar", 22);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}