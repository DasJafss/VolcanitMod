using Volcanit.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Weapons.Throwables
{
	public class HellianeDisk : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Helliane Disc");
		}

		public override void SetDefaults()
		{
			item.useStyle = 1;
			item.width = 1;
			item.height = 1;
			item.useAnimation = 12;
			item.useTime = 12;
			item.melee = true;
			item.shootSpeed = 5f;
			item.knockBack = 2.5f;
			item.damage = 30;
			item.channel = true;
			item.noUseGraphic = true;
			item.autoReuse = true;
			item.UseSound = SoundID.Item1;
			item.maxStack = 7;
			item.shoot = ModContent.ProjectileType<HellianeDisc>();
		}

		public override bool CanUseItem(Player player) {
			bool result2 = true;
			int nonhellianes = 0;
			nonhellianes = 0;
			if (result2 == false) {
			result2 = true;
			}
			for(int i = 0; i < 1000; i++) {
				if (Main.projectile[i].type == ModContent.ProjectileType<HellianeDisc>() && Main.projectile[i].active == true) {
			result2 = false;
			}
				if (Main.projectile[i].type != ModContent.ProjectileType<HellianeDisc>()) {
			nonhellianes -= 1;
			}
				if (Main.projectile[i].type == ModContent.ProjectileType<HellianeDisc>() && Main.projectile[i].active == false) {
			nonhellianes -= 1;
			}
			}
			if (nonhellianes + 1000 < item.stack) {
			result2 = true;
			}
			return result2;
		}
	}
}
