using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Projectiles
{
	public class NimbossThunder : ModProjectile
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
			if(projectile.ai[0]!=1) {
				for (int i = 0; i < 30; i++) {
					if (i < 1) {
						prevPos = projectile.position.X - 11 + Main.rand.Next(22);
						Projectile.NewProjectile(prevPos, 8 + projectile.Center.Y, 0, 0f, ModContent.ProjectileType<Projectiles.NimbossThunderB>(), 0, 0f);
					}
					if (i >= 1) {
						Projectile.NewProjectile(prevPos - 11 + Main.rand.Next(22), i * 16 + projectile.Center.Y , 0, 0f, ModContent.ProjectileType<Projectiles.NimbossThunderB>(), 0, 0f);
					}
					projectile.ai[0]=1;
					prevPos = prevPos - 11 + Main.rand.Next(22);
				}
			}
		}
	}
}