using Microsoft.Xna.Framework;
using MonoMod.Cil;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Volcanit.Npcs
{
	internal class SandWorm : ModNPC
	{
		public override bool Autoload(ref string name) {
			IL.Terraria.Wiring.HitWireSingle += HookStatue;
			return base.Autoload(ref name);
		}

		private void HookStatue(ILContext il) {
			var c = new ILCursor(il);


			ILLabel[] targets = null;
			while (c.TryGotoNext(i => i.MatchSwitch(out targets))) {
				int offset = 0;
				if (c.Prev.MatchSub() && c.Prev.Previous.MatchLdcI4(out offset)) {
					;
				}
				// not enough switch instructions
				if (targets.Length < 56 - offset) {
					continue;
				}
				var target = targets[56 - offset];
				if (target == null) {
					continue;
				}
				// move the cursor to case 56:
				c.GotoLabel(target);
				c.GotoNext(i => i.MatchCall(typeof(Utils), nameof(Utils.SelectRandom)));
				c.EmitDelegate<Func<short[], short[]>>(arr => {
					Array.Resize(ref arr, arr.Length+1);
					arr[arr.Length-1] = (short)npc.type;
					return arr;
				});

				// hook applied successfully
				return;
			}

			// couldn't find the right place to insert
			throw new Exception("Hook location not found, switch(*) { case 56: ...");
		}

		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Sand Worm");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Worm];
			Main.npcCatchable[npc.type] = true;
		}

		public override void SetDefaults() {
			//npc.width = 14;
			//npc.height = 14;
			//npc.aiStyle = 67;
			//npc.damage = 0;
			//npc.defense = 0;
			//npc.lifeMax = 5;
			//npc.HitSound = SoundID.NPCHit1;
			//npc.DeathSound = SoundID.NPCDeath1;
			//npc.npcSlots = 0.5f;
			//npc.noGravity = true;
			//npc.catchItem = 2007;

			npc.CloneDefaults(NPCID.Worm);
			npc.catchItem = (short)ItemType<SandWormItem>();
			npc.lavaImmune = true;
			//npc.aiStyle = 0;
			npc.friendly = true; // We have to add this and CanBeHitByItem/CanBeHitByProjectile because of reasons.
			aiType = NPCID.Worm;
			animationType = NPCID.Worm;
		}

		public override bool? CanBeHitByItem(Player player, Item item) {
			return true;
		}

		public override bool? CanBeHitByProjectile(Projectile projectile) {
			return true;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo) {
			if(Main.hardMode) {
			if(Main.LocalPlayer.ZoneSandstorm) {
			return 0.1f;
			} else {
			return 0.0f;
			}
			} else {
			return 0.0f;
			}
		}

		public override void HitEffect(int hitDirection, double damage) {
			if (npc.life <= 0) {
				for (int i = 0; i < 6; i++) {
					int dust = Dust.NewDust(npc.position, npc.width, npc.height, 200, 2 * hitDirection, -2f);
					if (Main.rand.NextBool(2)) {
						Main.dust[dust].noGravity = true;
						Main.dust[dust].scale = 1.2f * npc.scale;
					}
					else {
						Main.dust[dust].scale = 0.7f * npc.scale;
					}
				}
			}
		}

		public override void OnCatchNPC(Player player, Item item) {
			item.stack = 1;

			try {
				var npcCenter = npc.Center.ToTileCoordinates();
				if (!WorldGen.SolidTile(npcCenter.X, npcCenter.Y) && Main.tile[npcCenter.X, npcCenter.Y].liquid == 0) {
					WorldGen.SquareTileFrame(npcCenter.X, npcCenter.Y, true);
				}
			}
			catch {
				return;
			}
		}
	}
	
	
	internal class SandWormItem : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Sand Worm");
			Tooltip.SetDefault("Summons Sandtron");
		}

		public override void SetDefaults() {
			item.width = 26;
			item.height = 28;
			item.value = 1000;
			item.rare = 3;
			item.useStyle = 4;
			item.useTime = 10;
			item.useAnimation = 10;
			item.UseSound = SoundID.Item3;
			item.autoReuse = true;
			item.maxStack = 99;
			item.consumable = true;
		}
		public override bool CanUseItem(Player player)
		{
			if(Main.LocalPlayer.ZoneDesert)
			{
				if(!NPC.AnyNPCs(mod.NPCType("Sandtron"))) {
				return true;
			} else {
			return false;
			}
			} else {
				return false;
			}
		}
		public override bool UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("Sandtron"));
			return true;
		}
	}
}