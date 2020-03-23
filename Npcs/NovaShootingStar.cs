using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Volcanit.Projectiles;

namespace Volcanit.Npcs
{
	public class NovaShootingStar : ModNPC
	{
		public override void SetStaticDefaults()
		{
		DisplayName.SetDefault("Shooting Star");
		}
		public override void SetDefaults()
		{
			npc.aiStyle = 22;
			npc.lifeMax = 20;
			npc.damage = 25;
			npc.defense = 10;
			npc.knockBackResist = 0.1f;
			npc.width = 22;
			npc.height = 24;
			Main.npcFrameCount[npc.type] = 1;
			npc.npcSlots = 0.1f;
			npc.lavaImmune = true;
			npc.noGravity = true;
			npc.noTileCollide = true;
			npc.netAlways = true;
			}
			int Timer = 0;
			public override void AI() {
			Vector2 delta = new Vector2(0f, 5f);
			Timer += 1;
			if(Timer == 120) {
			Projectile.NewProjectile(npc.Center.X, npc.Center.Y, delta.X, delta.Y, ModContent.ProjectileType<SmallStar>(), 5, 1f, Main.myPlayer);
			Timer = 0;
			}
			}
		public override void HitEffect(int hitDirection, double damage) {
			if (npc.life <= 0) {
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/ShootingStarFragment"), npc.scale);
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/ShootingStarFragment"), npc.scale);
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/ShootingStarFragment"), npc.scale);
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/ShootingStarFragment"), npc.scale);
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/ShootingStarFragment"), npc.scale);
			}
		}
	}
}