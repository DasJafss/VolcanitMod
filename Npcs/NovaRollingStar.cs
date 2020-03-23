using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Npcs
{
	public class NovaRollingStar : ModNPC
	{
		public override void SetStaticDefaults()
		{
		DisplayName.SetDefault("Rolling Star");
		}
		public override void SetDefaults()
		{
			npc.CloneDefaults(NPCID.Tumbleweed);
			npc.lifeMax = 20;
			npc.damage = 25;
			npc.defense = 10;
			npc.knockBackResist = 0.1f;
			npc.width = 22;
			npc.height = 24;
			Main.npcFrameCount[npc.type] = 1;
			npc.npcSlots = 0.1f;
			npc.lavaImmune = true;
			npc.netAlways = true;
			}
		public override void HitEffect(int hitDirection, double damage) {
			if (npc.life <= 0) {
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/RollingStarFragment"), npc.scale);
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/RollingStarFragment"), npc.scale);
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/RollingStarFragment"), npc.scale);
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/RollingStarFragment"), npc.scale);
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/RollingStarFragment"), npc.scale);
			}
		}
	}
}