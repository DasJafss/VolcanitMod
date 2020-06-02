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
	public class Nimboss : ModNPC
	{
		public override void SetStaticDefaults()
		{
		DisplayName.SetDefault("Nimboss");
		}
		public override void SetDefaults()
		{
			npc.aiStyle = -1;
			npc.lifeMax = 70000;
			npc.damage = 60;
			npc.defense = 10;
			npc.knockBackResist = 0.1f;
			npc.width = 114;
			npc.height = 92;
			Main.npcFrameCount[npc.type] = 1;
			npc.npcSlots = 10f;
			npc.lavaImmune = true;
			npc.noGravity = true;
			npc.noTileCollide = true;
			npc.netAlways = true;
			npc.boss = true;
			music = MusicID.Boss3;
		}
		public override void BossLoot(ref string name, ref int potionType)
		{
		potionType = ItemID.HealingPotion;
		if (Main.rand.Next(2) == 0)
			Item.NewItem(npc.getRect(), ModContent.ItemType<Items.Weapons.Magic.NimbossScepter>());
			VolcanitWorld.downedCloud = true;
		}
		float NPCVX = 0f;
		float NPCVY = 0f;
		Vector2 oldPlayerPos;
		public override void AI() {
			npc.ai[2]++;
			if(npc.ai[2]<=180) {
					npc.ai[0]=1;
			}
			npc.ai[1]++;
			npc.TargetClosest(true);
			if(npc.ai[1]>180) {
				npc.ai[0]=Main.rand.Next(10);
				npc.ai[1]=0;
				oldPlayerPos=Main.player[npc.target].position;
				NPCVX=0f;
				NPCVY=0f;
			}
			npc.velocity += new Vector2(NPCVX, NPCVY) * 0.075f;
            npc.velocity *= 0.95f;
            if (npc.velocity.Length() > new Vector2(NPCVX, NPCVY).Length())
            {
                npc.velocity.Normalize();
                npc.velocity *= new Vector2(NPCVX, NPCVY).Length();
            }
			if(npc.ai[0]==0 || npc.ai[0]==5) {
				npc.damage = 60;
				NPCVX = 0f;
				NPCVY = 0f;
				if (oldPlayerPos.X < npc.position.X) {
					NPCVX=-8f;
				}
				if (oldPlayerPos.X > npc.position.X) {
					NPCVX=8f;
				}
				if (oldPlayerPos.Y < npc.position.Y) {
					NPCVY=-8f;
				}
				if (oldPlayerPos.Y > npc.position.Y) {
					NPCVY=8f;
				}
			}
			if(npc.ai[0]==1 || npc.ai[0]==4) {
				NPCVY=0f;
				NPCVX=0f;
				if(Main.player[npc.target].position.Y - 200<npc.position.Y) {
					NPCVY=-4f;
				}
				if(Main.player[npc.target].position.Y -206>npc.position.Y) {
					NPCVY=4f;
				}
				NPCVX = npc.direction * 2;
				if(Main.rand.Next(4)==0) {
					Projectile.NewProjectile(npc.position.X + Main.rand.Next(100), npc.Center.Y, 0, 0f, ModContent.ProjectileType<Projectiles.NimbossRain>(), 0, 0f, Main.myPlayer, npc.whoAmI);
				}
			}
			if(npc.ai[0]==2) {
				NPCVY=0f;
				NPCVX=0f;
				if(Main.player[npc.target].position.Y<npc.position.Y) {
					NPCVY=-4f;
				}
				if(Main.player[npc.target].position.Y>npc.position.Y) {
					NPCVY=4f;
				}
				if(Main.player[npc.target].position.X-200<npc.position.X) {
					NPCVX=-4f;
				}
				if(Main.player[npc.target].position.X-206>npc.position.X) {
					NPCVX=4f;
				}
				if(Main.rand.Next(4)==0) {
					Projectile.NewProjectile(npc.Center.X, npc.position.Y - 50 + Main.rand.Next(100), 0, 0f, ModContent.ProjectileType<Projectiles.NimbossWind>(), 0, 0f, Main.myPlayer, npc.whoAmI);
				}
				if(Main.rand.Next(30)==0) {
					Projectile.NewProjectile(npc.Center.X, npc.position.Y - 50 + Main.rand.Next(100), 0, 0f, ModContent.ProjectileType<Projectiles.NimbossBranch>(), 0, 0f, Main.myPlayer, npc.whoAmI);
				}
			}
			if(npc.ai[0]==3) {
				NPCVY=0f;
				NPCVX=0f;
				if(Main.player[npc.target].position.Y<npc.position.Y) {
					NPCVY=-4f;
				}
				if(Main.player[npc.target].position.Y>npc.position.Y) {
					NPCVY=4f;
				}
				if(Main.player[npc.target].position.X+200<npc.position.X) {
					NPCVX=-4f;
				}
				if(Main.player[npc.target].position.X+206>npc.position.X) {
					NPCVX=4f;
				}
				if(Main.rand.Next(4)==0) {
					Projectile.NewProjectile(npc.Center.X, npc.position.Y - 50 + Main.rand.Next(100), 0, 0f, ModContent.ProjectileType<Projectiles.NimbossWindB>(), 0, 0f, Main.myPlayer, npc.whoAmI);
				}
				if(Main.rand.Next(30)==0) {
					Projectile.NewProjectile(npc.Center.X, npc.position.Y - 50 + Main.rand.Next(100), 0, 0f, ModContent.ProjectileType<Projectiles.NimbossBranchB>(), 0, 0f, Main.myPlayer, npc.whoAmI);
				}
			}
			if(npc.ai[0]==6 || npc.ai[0]==7) {
				NPCVY=0f;
				NPCVX=0f;
				if(Main.player[npc.target].position.Y - 200<npc.position.Y) {
					NPCVY=-4f;
				}
				if(Main.player[npc.target].position.Y -206>npc.position.Y) {
					NPCVY=4f;
				}
				NPCVX = npc.direction * 2;
				if(Main.rand.Next(100)==0) {
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<Npcs.NimbossMinion>(), npc.whoAmI, 0);
				}
			}
			if(npc.ai[0]==8 || npc.ai[0]==9) {
				NPCVY=0f;
				NPCVX=0f;
				if(Main.player[npc.target].position.Y - 200<npc.position.Y) {
					NPCVY=-4f;
				}
				if(Main.player[npc.target].position.Y -206>npc.position.Y) {
					NPCVY=4f;
				}
				NPCVX = npc.direction * 2;
				if(Main.rand.Next(50)==0) {
						Projectile.NewProjectile(npc.Center.X, npc.position.Y, 0, 0f, ModContent.ProjectileType<Projectiles.NimbossThunder>(), 0, 0f, Main.myPlayer, npc.whoAmI);
				}
			}
		}
	}
}