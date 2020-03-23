using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Projectiles
{
	public class SandstormJavelinProjectile : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Sandstorm Javelin");
			Main.projFrames[projectile.type] = 1;
		}

		public override void SetDefaults() {
			projectile.CloneDefaults(507);
			aiType = 507;
		}
	}
}