using Volcanit.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items
{
	public class Rock : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Rock");
		}

		public override void SetDefaults()
		{
			item.useStyle = 1;
			item.width = 1;
			item.height = 1;
			item.useAnimation = 12;
			item.useTime = 12;
			item.thrown = true;
			item.consumable = true;
			item.shootSpeed = 4f;
			item.knockBack = 2.5f;
			item.damage = 6;
			item.channel = true;
			item.noUseGraphic = true;
			item.autoReuse = true;
			item.UseSound = SoundID.Item1;
			item.maxStack = 999;
			item.shoot = ModContent.ProjectileType<RockThrown>();
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(3, 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
