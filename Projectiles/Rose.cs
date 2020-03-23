using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.GameContent.Achievements;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Projectiles
{
	internal class Rose : ModProjectile
	{
		public override void SetDefaults() {
			projectile.width = 15;
			projectile.height = 15;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.timeLeft = 300;
			drawOffsetX = 5;
			drawOriginOffsetY = 5;
		}

		public override void ModifyHitNPC(NPC target, ref int damage, ref float knockback, ref bool crit, ref int hitDirection) {
			if (Main.expertMode) {
				if (target.type >= NPCID.EaterofWorldsHead && target.type <= NPCID.EaterofWorldsTail) {
					damage /= 5;
				}
			}
		}
		bool hasLanded = false;
		public override bool OnTileCollide(Vector2 oldVelocity) {
			if (projectile.ai[1] != 0) {
				return true;
			}
			projectile.velocity.X = 0f;
			projectile.velocity.Y = 0f;
			hasLanded = true;
			return false;
		}
		public override void AI() {
			if (projectile.owner == Main.myPlayer && projectile.timeLeft <= 3) {
				projectile.tileCollide = false;
				projectile.alpha = 255;
				projectile.position = projectile.Center;
				projectile.width = 250;
				projectile.height = 250;
				projectile.Center = projectile.position;
				projectile.damage = 25;
				projectile.knockBack = 10f;
			}
			projectile.ai[0] += 1f;
			if (projectile.ai[0] > 5f) {
				projectile.ai[0] = 10f;
			}
			projectile.rotation = projectile.velocity.ToRotation() + 45;
			if (!hasLanded)
				Dust.NewDust(projectile.position, projectile.width, projectile.height, mod.DustType("RoseDust"), projectile.velocity.X, projectile.velocity.Y);
			return;
		}

		public override void Kill(int timeLeft) {
			Main.PlaySound(SoundID.Item14, projectile.position);
			for (int g = 0; g < 100; g++) {
				Dust.NewDust(projectile.position, projectile.width, projectile.height, mod.DustType("RoseDust"));
			}
			projectile.position.X = projectile.position.X + (float)(projectile.width / 2);
			projectile.position.Y = projectile.position.Y + (float)(projectile.height / 2);
			projectile.width = 10;
			projectile.height = 10;
			projectile.position.X = projectile.position.X - (float)(projectile.width / 2);
			projectile.position.Y = projectile.position.Y - (float)(projectile.height / 2);
		}
	}
}