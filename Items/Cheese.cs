using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items
{
	public class Cheese : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Cheese");
		}

		public override void SetDefaults() 
		{
			item.width = 17;
			item.height = 15;
			item.crit = 63;
			item.knockBack = -20;
			item.value = 1000;
			item.rare = 2;
			item.useStyle = 2;
			item.useTime = 10;
			item.useAnimation = 15;
			item.UseSound = SoundID.Item3;
			item.autoReuse = true;
			item.maxStack = 666;
			item.consumable = true;
			item.buffType = BuffID.WellFed;
			item.buffTime = 36000;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CheeseBlockItem", 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}