using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Projectiles
{
	public class NimbossBranchB : ModProjectile
	{
		public override string Texture => "Volcanit/Items/SharpStick";
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Broken Branch");
		}

		public override void SetDefaults() {
			projectile.hostile = true;
			projectile.friendly = false;
			projectile.timeLeft = 180;
		}
		public override void AI() {
			projectile.damage = 40;
			projectile.velocity.X-=0.2f;
			if(projectile.velocity.X<-5f)
				projectile.velocity.X=-5f;
			projectile.rotation -= 0.1f;
		}
		public override void ModifyHitPlayer(Player target, ref int damage, ref bool crit) {
			target.velocity.X-= 3.0f;
		}
	}
}