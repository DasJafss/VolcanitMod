using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Projectiles
{
	public class MetalGuardian : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Prime Guardian");
			Main.projFrames[projectile.type] = 1;
			Main.projPet[projectile.type] = true;
		}

		public override void SetDefaults() {
			projectile.CloneDefaults(ProjectileID.ZephyrFish);
			aiType = ProjectileID.ZephyrFish;
		}

		public override bool PreAI() {
			Player player = Main.player[projectile.owner];
			player.zephyrfish = false; // Relic from aiType
			return true;
		}

		public override void AI() {
			Player player = Main.player[projectile.owner];
			VolcanitPlayer modPlayer = player.GetModPlayer<VolcanitPlayer>();
			if (player.dead) {
				modPlayer.primeGuardian = false;
			}
			if (modPlayer.primeGuardian) {
				projectile.timeLeft = 2;
			}
		}
	}
}