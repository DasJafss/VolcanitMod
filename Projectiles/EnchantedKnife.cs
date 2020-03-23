using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Projectiles
{
	public class EnchantedKnife : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Enchanted Knife");
			Main.projFrames[projectile.type] = 1;
		}

		public override void SetDefaults() {
			projectile.CloneDefaults(182);
			aiType = 182;
		}
	}
}