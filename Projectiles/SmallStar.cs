using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Projectiles
{
	public class SmallStar : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Small Star");
			Main.projFrames[projectile.type] = 2;
		}

		public override void SetDefaults() {
			projectile.CloneDefaults(182);
			aiType = 182;
			projectile.hostile = true;
			projectile.friendly = false;
			projectile.width = 14;
			projectile.height = 14;
		}
		int timer = 0;
		public override void AI() {
			timer += 1;
			if (timer >= 30)
				projectile.frame = 1;
			if (timer < 30)
				projectile.frame = 0;
			if (timer > 59)
				timer = 0;
		}
	}
}