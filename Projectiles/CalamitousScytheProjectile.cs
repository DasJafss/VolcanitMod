using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Volcanit.Projectiles
{
	public class CalamitousScytheProjectile : ModProjectile
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Calamitous Scythe");
		}

		public override void SetDefaults() {
			projectile.width = 60;
			projectile.height = 64;
			projectile.aiStyle = 0;
			projectile.penetrate = -1;
			projectile.alpha = 0;

			projectile.hide = true;
			projectile.ownerHitCheck = true;
			projectile.melee = true;
			projectile.tileCollide = false;
			projectile.friendly = true;
		}

		int timer = 0;
		public override void AI() {
			Player projOwner = Main.player[projectile.owner];
			Vector2 ownerMountedCenter = projOwner.RotatedRelativePoint(projOwner.MountedCenter, true);
			projOwner.heldProj = projectile.whoAmI;
			projOwner.itemTime = projOwner.itemAnimation;
			projectile.position.X = ownerMountedCenter.X - (float)(projectile.width / 2);
			projectile.position.Y = ownerMountedCenter.Y - (float)(projectile.height / 2);
			timer += 1;
			if (timer > 2) {
				projectile.rotation += 1;
				timer = 0;
			}
			if (projOwner.itemAnimation == 0) {
				projectile.Kill();
			}
		}
	}
}