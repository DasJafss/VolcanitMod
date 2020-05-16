using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Projectiles
{
	public class NimbossThunderB : ModProjectile
	{
		public override string Texture => "Terraria/Projectile_466";
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Thunder");
		}

		public override void SetDefaults() {
			projectile.hostile = true;
			projectile.friendly = false;
			projectile.timeLeft = 30;
			projectile.tileCollide = true;
			projectile.height = 22;
			projectile.width = 22;
		}
		float prevPos;
		public override void AI() {
			projectile.damage = 30;
		}
	}
}