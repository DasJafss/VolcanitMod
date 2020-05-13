using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Volcanit.Projectiles
{
	public class TundraSpike : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Icicle");
		}

		public override void SetDefaults() {
			projectile.hostile = false;
			projectile.friendly = true;
			projectile.timeLeft = 180;
			projectile.height = 20;
			projectile.width = 32;
			projectile.penetrate = -1;
		}
		public override void AI() {
			if (!landed)
				projectile.rotation = projectile.velocity.ToRotation();
		}
		bool landed;
		public override bool OnTileCollide(Vector2 oldVelocity) {
			projectile.timeLeft -= 3;
			projectile.velocity.X = 0f;
			projectile.velocity.Y = 0f;
			landed = true;
			return false;
		}
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) {
			if (!target.immortal && target.realLife < 0 && !target.boss)
			target.AddBuff(mod.BuffType("GoWFreeze"), 120);
		}
	}
}