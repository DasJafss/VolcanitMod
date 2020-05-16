using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace Volcanit.Projectiles
{
	public class DesertCloud : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Dust Cloud");
		}

		public override void SetDefaults() {
			projectile.hostile = false;
			projectile.friendly = true;
			projectile.timeLeft = 180;
			projectile.height = 22;
			projectile.width = 30;
			projectile.tileCollide = false;
		}
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) {
			target.AddBuff(BuffID.Confused, 120);
		}
	}
}