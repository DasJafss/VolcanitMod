using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using static Terraria.ModLoader.ModContent;

namespace Volcanit.Items.Weapons.Guns
{
	public class CalamitousSniper : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Calamitous Sniper");
		}

		public override void SetDefaults() {
			item.damage = 250;
			item.ranged = true;
			item.width = 80;
			item.height = 26;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 4;
			item.value = 150000;
			item.rare = 12;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 16f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CalamitousBar", 26);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}