using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Projectiles
{
	public class NimbossWindB : ModProjectile
	{
		public override string Texture => "Volcanit/Projectiles/NimbossWind";
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Wind");
			Main.projFrames[projectile.type] = 3;
		}

		public override void SetDefaults() {
			projectile.hostile = true;
			projectile.friendly = false;
			projectile.timeLeft = 180;
			projectile.height = 6;
		}
		int timer;
		public override void AI() {
			timer++;
			if(timer>20)
				projectile.frame = 1;
			if(timer<=20)
				projectile.frame = 0;
			if(timer>40)
				projectile.frame = 2;
			if(timer>60)
				timer = 0;
			projectile.rotation = 3f;
			projectile.damage = 1;
			projectile.velocity.X-=0.1f;
			if(projectile.velocity.X<-5f)
				projectile.velocity.X=-5f;
		}
		public override void ModifyHitPlayer(Player target, ref int damage, ref bool crit) {
			target.velocity.X-= 1.0f;
		}
	}
}