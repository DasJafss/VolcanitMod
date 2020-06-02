using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Utilities;
using Terraria.ModLoader;
using Terraria.ID;
//Special Thanks to IDGCaptainRussia

namespace Volcanit.Items.Weapons.Meele
{
	class LeviathanAxe : ModItem
	{
		bool altfired = false;

		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Leviathan");
			Tooltip.SetDefault("Left click to swing, right click to throw\nLeaves your inventory, but returns after a while, or if it hits an enemy; hit enemies are frozen in place");
		}
		public override void SetDefaults()
		{
			item.useStyle = 1;
			item.melee = true;
			item.damage = 125;
			item.shootSpeed = 15f;
			item.shoot = mod.ProjectileType("LeviProj");
			item.useTurn = true;
			item.width = 8;
			item.height = 28;
			item.maxStack = 1;
			item.knockBack = 14;
			item.UseSound = SoundID.Item1;
			item.useAnimation = 8;
			item.useTime = 8;
			item.noUseGraphic = true;
			item.noMelee = true;
			item.autoReuse = true;
			item.value = Item.buyPrice(1, 0, 0, 0);
			item.rare = 10;
		}

		public override bool AltFunctionUse(Player player)
		{
			return true;
		}

		public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
				item.noUseGraphic = true;
				item.noMelee = true;

			}
			else
			{
				item.noUseGraphic = false;
				item.noMelee = false;

			}
			return true;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			if (player.altFunctionUse == 2)
			{
				return true;
			}
			return false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IceBlock, 500);
			recipe.AddIngredient(ItemID.FrostCore, 5);
			recipe.AddIngredient(3460, 1);
			recipe.AddTile(null, "VolcanitAnvils");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

	public class LeviProj : ModProjectile
	{

		float hittime = 1f;
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Leviathan");
		}

		public override void SetDefaults()
		{
			projectile.width = 64;
			projectile.height = 64;
			projectile.ignoreWater = true;
			projectile.hostile = false;
			projectile.friendly = true;
			projectile.tileCollide = false;
			projectile.melee = true;
			projectile.timeLeft = 120;
			projectile.penetrate = 12;
			aiType = 0;
			drawOriginOffsetX = 8;
			drawOriginOffsetY = -8;
		}

		public override bool CanDamage()
		{
			return projectile.ai[0] < 30f;
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			projectile.velocity *= -1f;
			projectile.penetrate = 9;
			projectile.ai[0] = 1000;
			if (!target.immortal && target.realLife < 0 && !target.boss)
			target.AddBuff(mod.BuffType("GoWFreeze"), 60 * 4);
			projectile.netUpdate = true;
		}

		public override string Texture
		{
			get { return ("Volcanit/Items/Weapons/Meele/LeviathanAxe"); }
		}

		public override void AI()
		{

			Lighting.AddLight(projectile.Center, Color.Aquamarine.ToVector3() * 0.5f);

			hittime = Math.Max(1f, hittime / 1.5f);
			float dist2 = 24f;
			
			Double num315 = 0;
			Vector2 thisloc = new Vector2((float)(Math.Cos((projectile.rotation - Math.PI / 2.0) + num315) * dist2), (float)(Math.Sin((projectile.rotation - Math.PI / 2.0) + num315) * dist2));
			int num316 = Dust.NewDust(new Vector2(projectile.position.X - 1, projectile.position.Y) + thisloc, projectile.width, projectile.height, mod.DustType("LeviDust"), 0f, 0f, 50, Color.White, 1f);
			Main.dust[num316].noGravity = true;
			Main.dust[num316].velocity = (thisloc / 30f) + (projectile.velocity / 2f);

			projectile.ai[0] = projectile.ai[0] + 1;
			projectile.velocity.Y += 0.1f;

			if (!Main.player[projectile.owner].dead)
			{
				Main.player[projectile.owner].itemAnimation += 1;
				Main.player[projectile.owner].itemTime += 1;
			}

			if (projectile.ai[0] > 30f && !Main.player[projectile.owner].dead)
			{



				Vector2 dist = (Main.player[projectile.owner].Center - projectile.Center);
				Vector2 distnorm = dist; distnorm.Normalize();
				projectile.velocity += distnorm * 5f;
				projectile.velocity /= 1.05f;

				if (dist.Length() < 80)
				{
					projectile.Kill();
				}
				else
				{
					projectile.timeLeft = 5;
				}
			}

			projectile.rotation += 0.38f;
		}


	}

	public class LeviDust : ModDust
	{
		public override void OnSpawn(Dust dust)
		{
			dust.noGravity = true;
			dust.frame = new Rectangle(0, Main.rand.Next(0, 3) * 10, 14, 10);
		}

		public override bool Update(Dust dust)
		{
			dust.position += dust.velocity;
			dust.velocity *= 0.95f;
			dust.scale -= 0.01f;
			dust.color = dust.color * ((float)dust.alpha / 100f);

			dust.alpha -= 1;
			if (dust.alpha < 1)
				dust.scale -= 0.05f;
			if (dust.scale <= 0f)
				dust.active = false;
			return false;
		}

		public override Color? GetAlpha(Dust dust, Color lightColor)
		{
			return new Color(lightColor.R, lightColor.G, lightColor.B, dust.alpha);
		}
	}

	public class GoWFreeze : ModBuff
	{

		public override bool Autoload(ref string name, ref string texture)
		{
			texture = "Volcanit/Items/Weapons/Meele/LeviathanAxe";
			return true;
		}
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Na");
			Description.SetDefault("Not for players to see!");
			Main.debuff[Type] = true;
			Main.pvpBuff[Type] = false;
			Main.buffNoSave[Type] = true;
		}

		public override void Update(NPC npc, ref int buffIndex)
		{
			npc.GetGlobalNPC<GoWNPCs>().Freeze = true;
		}
	}

	public class GoWNPCs : GlobalNPC
	{

		public bool Freeze = false;
		public override bool InstancePerEntity
		{
			get
			{
				return true;
			}
		}

		public override void ResetEffects(NPC npc)
		{
			Freeze = false;
		}

		public override void DrawEffects(NPC npc, ref Color drawColor)
		{
			if (Freeze)
			{
				drawColor = Color.Aqua;

				if (Main.rand.Next(4) == 0)
				{
					int dust = Dust.NewDust(npc.position - new Vector2(2f, 2f), npc.width + 4, npc.height + 4, ModContent.DustType<LeviDust>(), npc.velocity.X * 0.4f, npc.velocity.Y * 0.4f, 100, default(Color), 1f);
					Main.dust[dust].noGravity = true;
					Main.dust[dust].velocity *= 1.8f;
					Main.dust[dust].velocity.Y += 0.5f;
					Main.playerDrawDust.Add(dust);
				}

			}
		}

		public override bool PreAI(NPC npc)
		{
			if (Freeze)
			{
				if (Collision.CanHit(npc.Center + new Vector2(0, npc.height / 2), 16, 16, npc.Center + new Vector2(0, 4) + new Vector2(0, npc.height / 2), npc.width, npc.height))
				{
					npc.velocity.Y += 0.05f;
					if (npc.velocity.Y>3)
					npc.velocity.Y = 3;
				}
				npc.velocity /= 1.04f;
				return false;
			}
			return true;
		}


	}

}