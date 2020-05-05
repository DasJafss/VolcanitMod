using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Volcanit.Projectiles
{
	public class Wave : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Wave");
		}

		public override void SetDefaults() {
			projectile.aiStyle = 0;
			projectile.hostile = false;
			projectile.friendly = true;
			projectile.width = 124;
			projectile.height = 96;
			projectile.timeLeft = 200;
			projectile.penetrate = 10000;
			projectile.maxPenetrate = 10000;
		}

		public override void AI() {
			
			projectile.rotation = 0;
			if (projectile.velocity.X < 0f)
				projectile.velocity.X = -6f;
			if (projectile.velocity.X > 0f)
				projectile.velocity.X = 6f;
			projectile.velocity.Y = 2f;
			if (stuck > 0)
				stuck -= 1;
			projectile.penetrate = 10000;
			if (stuck > 10) {
				continueStuck += 1;
				projectile.position.Y -= 16;
				stuck = 0;
			}
			if (!hasRecordedVel) {
					recordedXVel = projectile.velocity.X;
					hasRecordedVel = true;
			}
			projectile.velocity.X = recordedXVel;
			if (projectile.velocity.X < 0f)
				projectile.spriteDirection = -1;
			if (projectile.velocity.X > 0f)
				projectile.spriteDirection = 1;
		}
		int continueStuck;
		int stuck;
		bool hasRecordedVel = false;
		float recordedXVel;
		public override bool OnTileCollide(Vector2 oldVelocity) {
				Collision.HitTiles(projectile.position + projectile.velocity, projectile.velocity, projectile.width, projectile.height);
				projectile.velocity.Y = -2f;
				stuck += 3;
			return false;
		}
	}
}