using Volcanit.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Volcanit.Items.Weapons.Melee
{
	public class GoldenHalberdWand : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Used to punish the gods.");
		}

		public override void SetDefaults() {
			item.damage = 500;
			item.useStyle = 5;
			item.useAnimation = 18;
			item.useTime = 24;
			item.shootSpeed = 7.5f;
			item.knockBack = 6.5f;
			item.width = 32;
			item.height = 32;
			item.scale = 1f;
			item.rare = 11;
			item.value = 1000000;

			item.melee = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.autoReuse = true;
			item.UseSound = SoundID.Item1;
			item.shoot = ProjectileType<GoldenHalberdProjectile>();
			item.mana = 50;
		}

		public override bool CanUseItem(Player player) {
			return player.ownedProjectileCounts[item.shoot] < 1;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "TwiliteBar", 35);
			recipe.AddTile(null, "VolcanitAnvils");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}