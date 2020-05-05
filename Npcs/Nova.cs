using System;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Npcs
{
	[AutoloadBossHead]
	public class Nova : ModNPC
	{
		public override void SetStaticDefaults()
		{
		DisplayName.SetDefault("Nova");
		}
		public override void SetDefaults()
		{
			npc.aiStyle = 10;
			npc.lifeMax = 5000;
			npc.damage = 25;
			npc.defense = 10;
			npc.knockBackResist = 0.0f;
			npc.width = 124;
			npc.height = 102;
			Main.npcFrameCount[npc.type] = 1;
			npc.npcSlots = 6f;
			npc.boss = true;
			npc.lavaImmune = true;
			npc.noGravity = true;
			npc.noTileCollide = true;
			npc.netAlways = true;
			npc.buffImmune[24] = true;
			music = MusicID.Boss2;
			}
			int Timer = 0;
			public override void AI() {
				Timer += 1;
				Main.dayTime = false;
				int latestNPC = npc.whoAmI;
				if(Timer == 120) {
					if(npc.life >= 4000) {
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, mod.NPCType("NovaFloatingStar"), npc.whoAmI, 0, latestNPC);
						Timer = 0;
					} else if(npc.life < 4000 && npc.life >= 3000) {
						if (Main.rand.Next(2) == 0) {
							NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, mod.NPCType("NovaFloatingStar"), npc.whoAmI, 0, latestNPC);
							Timer = 0;
						} else {
							NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, mod.NPCType("NovaFlyingStar"), npc.whoAmI, 0, latestNPC);
							Timer = 0;
							}
						} else if(npc.life < 3000 && npc.life >= 2000) {
							if (Main.rand.Next(3) == 0) {
								NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, mod.NPCType("NovaFloatingStar"), npc.whoAmI, 0, latestNPC);
								Timer = 0;
							} else if (Main.rand.Next(2) == 0) {
								NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, mod.NPCType("NovaFlyingStar"), npc.whoAmI, 0, latestNPC);
								Timer = 0;
							} else {
								NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, mod.NPCType("NovaRollingStar"), npc.whoAmI, 0, latestNPC);
								Timer = 0;
							}
						} else if(npc.life < 2000) {
								if (Main.rand.Next(4) == 0) {
									NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, mod.NPCType("NovaFloatingStar"), npc.whoAmI, 0, latestNPC);
									Timer = 0;
								} else if (Main.rand.Next(3) == 0) {
									NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, mod.NPCType("NovaFlyingStar"), npc.whoAmI, 0, latestNPC);
									Timer = 0;
								} else if (Main.rand.Next(2) == 0) {
									NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, mod.NPCType("NovaRollingStar"), npc.whoAmI, 0, latestNPC);
									Timer = 0;
								} else {
									NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, mod.NPCType("NovaShootingStar"), npc.whoAmI, 0, latestNPC);
									Timer = 0;
								}
							}
						}
					}
		public override void HitEffect(int hitDirection, double damage) {
			if (npc.life <= 0) {
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/SmallStarGore"), npc.scale);
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/SmallStarGore"), npc.scale);
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/SmallStarGore"), npc.scale);
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/SmallStarGore"), npc.scale);
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/SmallStarGore"), npc.scale);
				Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/SmallStarGore"), npc.scale);
				VolcanitWorld.downedNova = true;
			}
		}
public override void BossLoot(ref string name, ref int potionType)
		{
		potionType = ItemID.HealingPotion;
		if (Main.rand.Next(2) == 0)
			Item.NewItem(npc.getRect(), ModContent.ItemType<Items.StarshadeSlicer>());
		if (Main.rand.Next(2) == 0)
			Item.NewItem(npc.getRect(), ModContent.ItemType<Items.PainStarDX>());
		if (Main.rand.Next(2) == 0)
			Item.NewItem(npc.getRect(), ModContent.ItemType<Items.Starshot>());
		Item.NewItem(npc.getRect(), ModContent.ItemType<Items.StarShard>());
		}
		public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
		{
		npc.lifeMax = (int)(npc.lifeMax * 0.579f * bossLifeScale);
		npc.damage = (int)(npc.damage * 0.6f);
		}
	}
}