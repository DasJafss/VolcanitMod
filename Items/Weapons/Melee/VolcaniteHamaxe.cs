using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Weapons.Melee
{
	public class VolcaniteHamaxe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Volcanite Hamaxe");
		}

		public override void SetDefaults() 
		{
			item.damage = 120;
			item.melee = true;
			item.width = 46;
			item.axe = 70;
			item.hammer = 280;
			item.height = 52;
			item.useTime = 15;
			item.useAnimation = 15;
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
			recipe.AddIngredient(null, "VolcaniteBar", 23);
			recipe.AddTile(null, "VolcanitAnvils");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}