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
	public class EyeOfJafss : ModNPC
	{
		public override void SetStaticDefaults()
		{
		DisplayName.SetDefault("Eye of Jafss");
		}
		public override void SetDefaults()
		{
			npc.aiStyle = 5;
			npc.lifeMax = 12000;
			npc.damage = 50;
			npc.defense = 100;
			npc.knockBackResist = 0f;
			npc.width = 128;
			npc.height = 114;
			npc.npcSlots = 1f;
			npc.boss = true;
			npc.lavaImmune = true;
			npc.noGravity = true;
			npc.noTileCollide = true;
			music = MusicID.Boss1;
			npc.netAlways = true;
			}
		int Timer = 0;
		int Timer2 = 0;
		bool hasShed = false;
			public override void AI() {
				Timer += 1;
				Timer2 += 1;
				int latestNPC = npc.whoAmI;
					if(npc.life <= 9000 && Timer == 120 && npc.life > 8000) {
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, mod.NPCType("JafssFurball"), npc.whoAmI, 0, latestNPC);
					}
					if(npc.life <= 6000 && Timer == 120 && npc.life > 5000) {
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, mod.NPCType("JafssFurball"), npc.whoAmI, 0, latestNPC);
					}
					if(npc.life <= 4000 && Timer2 == 60) {
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, mod.NPCType("JafssFurball"), npc.whoAmI, 0, latestNPC);
					}
					if(Timer >= 120) {
					Timer = 0;
					}
					if(Timer2 >= 60) {
					Timer2 = 0;
					}
					}
		public override void HitEffect(int hitDirection, double damage) {
			if (npc.life <= 11000) {
				npc.defense = 20;
				npc.damage = 80;
				music = MusicID.Boss2;
			}
			if (npc.life <= 10000) {
				npc.defense = 50;
				npc.damage = 50;
				music = MusicID.Boss3;
				npc.noTileCollide = false;
			}
			if (npc.life <= 9000) {
				npc.defense = 50;
				npc.damage = 30;
				music = MusicID.Boss4;
				npc.noTileCollide = true;
			}
			if (npc.life <= 8000) {
				npc.defense = 50;
				npc.damage = 50;
				music = MusicID.Boss5;
			}
			if (npc.life <= 7000) {
				npc.defense = 50;
				npc.damage = 50;
				music = MusicID.Plantera;
				npc.noTileCollide = false;
				npc.noGravity = false;
			}
			if (npc.life <= 6000) {
				npc.defense = 50;
				npc.damage = 75;
				music = MusicID.PumpkinMoon;
				npc.noTileCollide = true;
				npc.noGravity = true;
			}
			if (npc.life <= 5000) {
				npc.defense = 100;
				npc.damage = 50;
				music = MusicID.FrostMoon;
				npc.noTileCollide = false;
			}
			if (npc.life <= 4000) {
				npc.defense = 50;
				npc.damage = 100;
				music = MusicID.LunarBoss;
				npc.aiStyle = -1;
				npc.noTileCollide = false;
				npc.noGravity = false;
			}
			if (npc.life <= 3000) {
				npc.defense = 75;
				npc.damage = 75;
				music = MusicID.OldOnesArmy;
				npc.aiStyle = 5;
				npc.noGravity = true;
			}
		}
		public override void BossLoot(ref string name, ref int potionType)
		{
		potionType = ItemID.HealingPotion;
		if (Main.rand.Next(2) == 0)
			Item.NewItem(npc.getRect(), ModContent.ItemType<Items.SightOfJafss>());
		if (Main.rand.Next(2) == 0)
			Item.NewItem(npc.getRect(), ModContent.ItemType<Items.Armor.MaskOfJafss>());
		if (Main.rand.Next(2) == 0)
			Item.NewItem(npc.getRect(), ModContent.ItemType<Items.HeroSword>());
		if (Main.rand.Next(2) == 0)
			Item.NewItem(npc.getRect(), ModContent.ItemType<Items.NiceLookingGlasses>());
		}
		public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
		{
		npc.lifeMax = (int)(npc.lifeMax * 0.579f * bossLifeScale);
		npc.damage = (int)(npc.damage * 0.6f);
		}
		public override bool PreDraw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch, Color drawColor)
        {
			Texture2D texture = Main.npcTexture[npc.type];
			Vector2 origin = new Vector2(texture.Width * 0.5f, texture.Height * 0.5f);
			Main.spriteBatch.Draw(texture, npc.Center - Main.screenPosition, new Rectangle?(), drawColor, npc.rotation, origin, npc.scale, SpriteEffects.None, 0);
	if (npc.life <= 3000)
            {
                spriteBatch.Draw(mod.GetTexture("Npcs/JafssTrueForm"), npc.Center - Main.screenPosition, new Rectangle?(), drawColor, npc.rotation, origin, npc.scale, SpriteEffects.None, 0);
		}
            }
            return false;
		}
	}
}