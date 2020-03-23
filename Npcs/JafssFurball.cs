using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Npcs
{
	public class JafssFurball : ModNPC
	{
		public override void SetStaticDefaults()
		{
		DisplayName.SetDefault("Minion of Jafss");
		}
		public override void SetDefaults()
		{
			npc.aiStyle = 5;
			npc.lifeMax = 100;
			npc.damage = 30;
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
	}
}