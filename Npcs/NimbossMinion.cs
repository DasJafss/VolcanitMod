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
	public class NimbossMinion : ModNPC
	{
		public override string Texture => "Terraria/NPC_250";
		public override void SetStaticDefaults()
		{
		DisplayName.SetDefault("Angry Nimbus");
		Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.AngryNimbus];
		}
		public override void SetDefaults()
		{
			npc.CloneDefaults(NPCID.AngryNimbus);
			aiType = NPCID.AngryNimbus;
			animationType = NPCID.AngryNimbus;
			npc.lifeMax = 150;
		}
	}
}