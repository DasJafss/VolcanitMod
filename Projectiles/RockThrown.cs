using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Projectiles
{
	public class RockThrown : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Rock");
			Main.projFrames[projectile.type] = 1;
		}

		public override void SetDefaults() {
			projectile.CloneDefaults(3);
			aiType = 3;
			projectile.width = 30;
			projectile.height = 24;
		}
	}
}