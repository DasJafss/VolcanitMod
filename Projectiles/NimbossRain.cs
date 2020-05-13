using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Projectiles
{
	public class NimbossRain : ModProjectile
	{
		public override string Texture => "Terraria/Projectile_239";
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Rain");
		}

		public override void SetDefaults() {
			projectile.hostile = true;
			projectile.friendly = false;
			projectile.timeLeft = 180;
		}
		public override void AI() {
			projectile.damage = 40;
			projectile.velocity.Y+=0.1f;
			if(projectile.velocity.Y>16f)
				projectile.velocity.Y=16f;
		}
	}
}