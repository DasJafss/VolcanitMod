using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items
{
	public class PainStar : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Pain Star");
			Tooltip.SetDefault("Somehow, this does damage. Do not question it.");
		}

		public override void SetDefaults() 
		{
			item.damage = 15;
			item.melee = true;
			item.width = 22;
			item.height = 24;
			item.useTime = 20;
			item.useAnimation = 20;
			item.crit = 90;
			item.useStyle = 4;
			item.knockBack = 100;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item29;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FallenStar, 5);
			recipe.AddIngredient(ItemID.Starfish, 3);
			recipe.AddIngredient(ItemID.LavaBucket, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}