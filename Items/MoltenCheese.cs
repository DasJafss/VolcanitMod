using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items
{
	public class MoltenCheese : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Molten Cheese");
			Tooltip.SetDefault("Cheesy");
		}

		public override void SetDefaults() 
		{
			item.damage = 109;
			item.melee = true;
			item.width = 48;
			item.height = 52;
			item.useTime = 30;
			item.useAnimation = 30;
			item.crit = 63;
			item.useStyle = 1;
			item.knockBack = -20;
			item.value = 100000;
			item.rare = 9;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Cheese", 3);
			recipe.AddIngredient(ItemID.FragmentSolar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}