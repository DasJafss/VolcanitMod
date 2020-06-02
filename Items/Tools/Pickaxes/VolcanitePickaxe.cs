using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Tools.Pickaxes
{
	public class VolcanitePickaxe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Volcanite Pickaxe");
		}

		public override void SetDefaults() 
		{
			item.damage = 60;
			item.melee = true;
			item.width = 46;
			item.pick = 240;
			item.height = 52;
			item.useTime = 5;
			item.useAnimation = 5;
			item.crit = 3;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 100000;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "VolcaniteBar", 20);
			recipe.AddTile(null, "VolcanitAnvils");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}