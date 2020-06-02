using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Volcanit.Projectiles;

namespace Volcanit.Items.Weapons.Meele
{
	public class DragonicChainblade : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Dragonic Chainblade");
			Tooltip.SetDefault("Can be used for both a sword and a grappling hook.");
		}

		public override void SetDefaults() 
		{
			item.damage = 75;
			item.melee = true;
			item.width = 41;
			item.height = 50;
			item.useTime = 12;
			item.useAnimation = 12;
			item.crit = 6;
			item.useStyle = 1;
			item.knockBack = 1;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.channel = true;
			item.value = 100000;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.shootSpeed = 15f;
			item.shoot = ModContent.ProjectileType<DragonicChainbladeHook>();
		}
		public override bool AltFunctionUse(Player player) {
			return true;
		}
		public override bool CanUseItem(Player player) {
			bool result = true;
			if (!result) {
			result = true;
			}
			for(int i = 0; i < 1000; i++) {
			if (Main.projectile[i].type == ModContent.ProjectileType<DragonicChainbladeHook>() && Main.projectile[i].active) {
			result = false;
			} else {
			if (player.altFunctionUse == 2) {
				item.useStyle = 3;
				item.shoot = ModContent.ProjectileType<DragonicChainbladeHook>();
				item.noMelee = true;
				item.noUseGraphic = true;
				item.autoReuse = false;
			}
			else {
				item.useStyle = 1;
				item.shoot = 0;
				item.noMelee = false;
				item.noUseGraphic = false;
				item.autoReuse = true;
			}
		}
		}
		return result;
		}
	}
}