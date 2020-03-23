using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Projectiles
{
	public class HellianeDisc : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Helliane Disk");
			Main.projFrames[projectile.type] = 1;
		}

		public override void SetDefaults() {
			projectile.width = 56;
			projectile.height = 56;
			projectile.aiStyle = 3;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.melee = true;
		}
	}
}