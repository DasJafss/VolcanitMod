using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Projectiles
{
	public class CursedOrbB : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Cursed Orb");
			Main.projFrames[projectile.type] = 4;
		}

		public override void SetDefaults() {
			projectile.CloneDefaults(101);
			aiType = 101;
			projectile.hostile = false;
			projectile.friendly = true;
		}

		int timer = 0;
		public override void AI() {
			timer += 1;
			if (timer >= 15 && timer < 30)
				projectile.frame = 1;
			if (timer < 15)
				projectile.frame = 0;
			if (timer >= 30 && timer < 45)
				projectile.frame = 2;
			if (timer >= 45)
				projectile.frame = 3;
			if (timer > 59)
				timer = 0;
		}
	}
}