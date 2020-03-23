using Volcanit.Items;
using Volcanit.Buffs;
using Volcanit.Projectiles;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameInput;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using static Terraria.ModLoader.ModContent;

namespace Volcanit
{
	public class VolcanitPlayer : ModPlayer
	{
		public bool primeGuardian;
		public bool manaHeart;
		public int manaHeartCounter;

		public const int maxLavacaHearts = 20;
		public int lavacaHearts;
		public const int maxManaBeans = 40;
		public int manaBeans;
		public const int maxStarShards = 10;
		public int starShards;


		public override void ResetEffects() {
			primeGuardian = false;
			if (!manaHeart) {
				manaHeartCounter = 0;
			}
			manaHeart = false;

			player.statLifeMax2 += lavacaHearts * 10;
			player.statManaMax2 += manaBeans * 5;
			player.statDefense += starShards;
		}

		public override void clientClone(ModPlayer clientClone) {
			VolcanitPlayer clone = clientClone as VolcanitPlayer;
		}

		public override void SyncPlayer(int toWho, int fromWho, bool newPlayer) {
			ModPacket packet = mod.GetPacket();
			packet.Write((byte)player.whoAmI);
			packet.Write(lavacaHearts);
			packet.Write(manaBeans);
			packet.Write(starShards);
			packet.Send(toWho, fromWho);
		}

		public override TagCompound Save() {
			return new TagCompound {
				{"lavacaHearts", lavacaHearts},
				{"manaBeans", manaBeans},
				{"starShards", starShards}
			};
		}

		public override void Load(TagCompound tag) {
			lavacaHearts = tag.GetInt("lavacaHearts");
			manaBeans = tag.GetInt("manaBeans");
			starShards = tag.GetInt("starShards");
		}

		public override void OnConsumeMana(Item item, int manaConsumed) {
			if (manaHeart) {
				manaHeartCounter += manaConsumed;
				if (manaHeartCounter >= 200) { 					
					if (Main.netMode != NetmodeID.Server) {
						Main.PlaySound(SoundID.Item4, player.position);
						player.statLife += 20;
						if (Main.myPlayer == player.whoAmI) {
							player.HealEffect(20, true);
						}
						if (player.statLife > player.statLifeMax2) {
							player.statLife = player.statLifeMax2;
						}
					}
					manaHeartCounter -= 200;
				}
			}
		}
	}
}