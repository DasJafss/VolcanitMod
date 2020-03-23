using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Projectiles
{
	public class CursedOrb : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Cursed Orb");
			Main.projFrames[projectile.type] = 4;
		}

		public override void SetDefaults() {
			projectile.CloneDefaults(95);
			aiType = 95;
			projectile.hostile = false;
			projectile.friendly = true;
		}
	}
}