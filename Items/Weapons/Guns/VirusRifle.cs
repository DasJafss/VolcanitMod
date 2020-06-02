using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using static Terraria.ModLoader.ModContent;

namespace Volcanit.Items.Weapons.Guns
{
	public class VirusRifle : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Virus Rifle");
		}

		public override void SetDefaults() {
			item.damage = 73;
			item.ranged = true;
			item.width = 44;
			item.height = 18;
			item.useTime = 13;
			item.useAnimation = 13;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 5;
			item.value = 150000;
			item.rare = 9;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 16f;
			item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CursedBar", 17);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}