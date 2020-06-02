using Volcanit.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Weapons.Throwables
{
	public class CalamitousKnife : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Calamitous Knife");
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
			item.shootSpeed = 5f;
			item.knockBack = 2.5f;
			item.damage = 175;
			item.channel = true;
			item.noUseGraphic = true;
			item.autoReuse = true;
			item.UseSound = SoundID.Item1;
			item.maxStack = 999;
			item.rare = 8;
			item.shoot = ModContent.ProjectileType<CalamitousKnive>();
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CalamitousBar", 2);
			recipe.AddTile(null, "VolcanitAnvils");
			recipe.SetResult(this, 30);
			recipe.AddRecipe();
		}
	}
}
