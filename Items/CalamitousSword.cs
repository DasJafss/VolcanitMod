using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items
{
	public class CalamitousSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Calamitous Sword");
		}

		public override void SetDefaults() 
		{
			item.damage = 330;
			item.melee = true;
			item.width = 84;
			item.height = 84;
			item.useTime = 13;
			item.useAnimation = 13;
			item.crit = 50;
			item.useStyle = 1;
			item.knockBack = 16;
			item.value = 150000;
			item.rare = 12;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CalamitousBar", 25);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}