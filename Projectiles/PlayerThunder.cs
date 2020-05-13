using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Volcanit.Projectiles
{
	public class PlayerThunder : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Thunder");
			Main.projFrames[projectile.type] = 4;
		}

		public override void SetDefaults() {
			projectile.hostile = false;
			projectile.friendly = true;
			projectile.timeLeft = 180;
			projectile.height = 28;
			projectile.width = 28;
			projectile.penetrate = -1;
		}
		public override void AI() {
			projectile.damage = 60;
			if(projectile.timeLeft<181)
				projectile.frame = 0;
			if(projectile.timeLeft<136)
				projectile.frame = 1;
			if(projectile.timeLeft<91)
				projectile.frame = 2;
			if(projectile.timeLeft<46)
				projectile.frame = 3;
			if(projectile.timeLeft<3) {
				projectile.height = 250;
				projectile.width = 250;
			}
		}
		public override bool OnTileCollide(Vector2 oldVelocity) {
			projectile.timeLeft -= 3;
			projectile.velocity.X = 0f;
			projectile.velocity.Y = 0f;
			return false;
		}
		public override void Kill(int timeLeft) {
			projectile.position.X = projectile.position.X - (float)(projectile.width / 2);
			projectile.position.Y = projectile.position.Y - (float)(projectile.height / 2);
			for (int g = 0; g < 100; g++) {
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 263);
			}
		}
	}
}