using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Volcanit.Projectiles;

namespace Volcanit.Items.Weapons.Yoyos
{
	public class CrystalYoyo : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Fiaryite Yoyo");
			Tooltip.SetDefault("Two Sided.\n50 Side 1 Damage\n25 Side 1 Crit\nNormal Side 1 Knockback\n 300 Side 1 Reach\n40 Side 2 Damage\n30 Side 2 Crit\nVery Strong Side 2 Knockback\n20 Side 2 Reach\nTrick Side 2");
			ItemID.Sets.Yoyo[item.type] = true;
			ItemID.Sets.GamepadExtraRange[item.type] = 15;
			ItemID.Sets.GamepadSmartQuickReach[item.type] = true;
		}

		public override void SetDefaults() 
		{
			item.melee = true;
			item.value = 25000;
			item.useStyle = 5;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.UseSound = SoundID.Item1;
			item.useAnimation = 4;
			item.useTime = 4;
			item.shootSpeed = 16f;
			item.rare = 8;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CrystalBar", 19);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override bool AltFunctionUse(Player player) {
			return true;
		}

		public override bool CanUseItem(Player player) {
			if (player.altFunctionUse == 2) {
				item.damage = 40;
				item.crit = 30;
				item.knockBack = 5;
				item.shoot = ModContent.ProjectileType<CrystalYoyoB>();
			}
			else {
				item.damage = 50;
				item.crit = 20;
				item.knockBack = 17;
				item.shoot = ModContent.ProjectileType<CrystalYoyoP>();
			}
		return true;
		}
	}
}