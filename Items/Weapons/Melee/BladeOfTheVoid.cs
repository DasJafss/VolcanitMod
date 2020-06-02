using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Weapons.Melee
{
	public class BladeOfTheVoid : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Blade of the Void");
			Tooltip.SetDefault("Sends your foes flying into the void.");
		}

		public override void SetDefaults() 
		{
			item.damage = 110;
			item.melee = true;
			item.width = 44;
			item.height = 48;
			item.useTime = 60;
			item.useAnimation = 60;
			item.crit = -4;
			item.useStyle = 1;
			item.knockBack = 20000000000000000;
			item.value = 100000;
			item.rare = 8;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TrueNightsEdge, 1);
			recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
			recipe.AddIngredient(ItemID.DarkLance, 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}