using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Weapons.Melee
{
	public class TwiliteSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Twilite Sword");
		}

		public override void SetDefaults() 
		{
			item.damage = 243;
			item.melee = true;
			item.width = 38;
			item.height = 38;
			item.useTime = 15;
			item.useAnimation = 15;
			item.crit = 46;
			item.useStyle = 1;
			item.knockBack = 15;
			item.value = 100000;
			item.rare = 11;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "TwiliteBar", 25);
			recipe.AddTile(null, "VolcanitAnvils");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}