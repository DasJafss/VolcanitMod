using Volcanit.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items
{
	public class AncientFossil : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Ancient Fossil");
            Tooltip.SetDefault("Smells ancient.");

			ItemID.Sets.Yoyo[item.type] = true;
			ItemID.Sets.GamepadExtraRange[item.type] = 15;
			ItemID.Sets.GamepadSmartQuickReach[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.width = 32;
			item.height = 28;
			item.useAnimation = 4;
			item.useTime = 4;
			item.shootSpeed = 16f;
			item.knockBack = 2.5f;
			item.damage = 50;
			item.rare = 5;
			item.melee = true;
			item.crit = 17;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.UseSound = SoundID.Item1;
			item.shoot = ModContent.ProjectileType<SandscaleYoyo>();
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SandScale", 15);
			recipe.AddIngredient(ItemID.SpectreBar, 12);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
