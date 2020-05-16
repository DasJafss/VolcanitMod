using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using Microsoft.Xna.Framework;

namespace Volcanit.Projectiles
{
	public class CursedOrb : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Cursed Orb");
			Main.projFrames[projectile.type] = 4;
		}

		public override void SetDefaults() {
			projectile.width = 12;
			projectile.height = 12;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.timeLeft = 600;
			projectile.hostile = false;
			projectile.tileCollide = true;
		}
		bool isInsideTile = false;
		int whileInsideTile = 0;
		public override bool OnTileCollide(Vector2 oldVelocity) {
			projectile.velocity.X = oldVelocity.X * 0.9f;
			projectile.velocity.Y = oldVelocity.Y * -0.9f;
			isInsideTile = true;
			if (isInsideTile)
				whileInsideTile++;
			if (whileInsideTile > 1)
				projectile.velocity.X = oldVelocity.X * -0.9f;
			return false;
		}
		int timer = 0;
		public override void AI() {
			timer += 2;
			if (timer >= 15 && timer < 30)
				projectile.frame = 1;
			if (timer < 15)
				projectile.frame = 0;
			if (timer >= 30 && timer < 45) {
				projectile.frame = 2;
				if (whileInsideTile > 1)
					whileInsideTile--;
				isInsideTile = false;
			}
			if (timer >= 45)
				projectile.frame = 3;
			if (timer > 59)
				timer = 0;
			if (projectile.velocity.Y < 16f)
			projectile.velocity.Y += 0.1f;
			Dust.NewDust(projectile.position, projectile.width, projectile.height, 107, projectile.velocity.X, projectile.velocity.Y);
		}
	}
}