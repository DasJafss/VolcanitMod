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
	public class VolcanicMimic : ModNPC
	{
		public override void SetStaticDefaults()
		{
		DisplayName.SetDefault("Volcanic Mimic");
		Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.BigMimicHallow];
		}
		public override void SetDefaults()
		{
			npc.CloneDefaults(NPCID.BigMimicHallow);
			aiType = NPCID.BigMimicHallow;
			animationType = NPCID.BigMimicHallow;
		}
		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			if(Main.hardMode) {
			if(Main.LocalPlayer.ZoneUnderworldHeight) {
			return 0.05f;
			} else {
			return 0.0f;
			}
			} else {
			return 0.0f;
			}
		}
		public override void HitEffect(int hitDirection, double damage) {
			if (npc.life <= 0) {
				if (Main.rand.Next(2) == 0)
					Item.NewItem(npc.getRect(), ModContent.ItemType<Items.HeartSeekerEdge>());
				if (Main.rand.Next(2) == 0)
					Item.NewItem(npc.getRect(), ModContent.ItemType<Items.DragonicChainblade>());
				Item.NewItem(npc.getRect(), ModContent.ItemType<Items.VolcanishBrew>(), Main.rand.Next(3, 10));
			}
		}
	}
}