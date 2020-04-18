using Volcanit.Tiles;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.DataStructures;
using Terraria.GameContent.Generation;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;
using Terraria.World.Generation;
using static Terraria.ModLoader.ModContent;

namespace Volcanit
{
	public class VolcanitWorld : ModWorld
	{
		public static bool volcaniteGen;
		public static bool moonlordDead;
		public static bool moonlordAlive;
		public static bool golemDead;
		public static bool golemAlive;
		public static bool planteraAlive;
		public static bool planteraDead;
		public static bool wofAlive;
		public static bool wofDead;
		public override void PostUpdate() {
		if(!Main.hardMode) {
			wofAlive = true;
		}
		if(NPC.AnyNPCs(398)) {
			moonlordAlive = true;
		}
		if(wofAlive && Main.hardMode) {
			wofAlive = false;
			wofDead = true;
		}
		if(moonlordAlive && !NPC.AnyNPCs(398)) {
			moonlordDead = true;
			moonlordAlive = false;
		}
		if(NPC.AnyNPCs(245)) {
			golemAlive = true;
		}
		if(golemAlive && !NPC.AnyNPCs(245)) {
			golemDead = true;
			golemAlive = false;
		}
		if(NPC.AnyNPCs(262)) {
			planteraAlive = true;
		}
		if(planteraAlive && !NPC.AnyNPCs(262)) {
			planteraDead = true;
			planteraAlive = false;
		}
		if(wofDead) {
		int ymodifier = 0;
		bool landed = false;
			for (ymodifier = 0; ymodifier < Main.maxTilesY - 1; ymodifier++) {
						if(Main.tile[64, ymodifier + 1].active() && !landed) {
						WorldGen.PlaceChest(64, ymodifier, Convert.ToUInt16(TileType<SunkenTreasureTile>()), false, 0);
						landed = true;
						Main.NewText("A treasure has sunken in the ocean!",0,0,255);
						NetMessage.BroadcastChatMessage(NetworkText.FromLiteral("A treasure has sunken in the ocean!"), Color.Blue);
						for (int chestIndex = 0; chestIndex < 1000; chestIndex++) {
				Chest chest = Main.chest[chestIndex];
				int[] ItemForChest = new int[104] {74,78,82,17,79,83,91,92,108,107,264,327,355,517,554,696,697,698,709,712,715,744,741,743,855,864,955,1355,1522,1523,1524,1525,1526,1527,1704,1705,1710,1716,1720,1987,2133,2137,2143,2147,2155,2238,2294,2308,2336,2335,2334,2379,2389,2405,2630,2663,2843,2889,2890,2891,2892,2893,2894,2895,3070,3071,3072,3073,3074,3075,3076,3096,3183,3229,3230,3231,3232,3233,3510,3511,3512,3513,3514,3515,3516,3517,3518,3519,3520,3521,3480,3481,3482,3483,3484,3485,3564,3566,3643,3816,3885,3887,3904,3910};
				int[] OtherForChest = new int[10] {177,178,179,180,181,182,999,1348,3027,3828};
				int[] SunkenTreasureExclus = new int[] {ItemType<Items.Pickanch>(),ItemType<Items.Riptide>(),ItemType<Items.NautilusSlicer>()};
				int Which = Main.rand.Next(7,8);
				if (chest != null && Main.tile[chest.x, chest.y].type == TileType<SunkenTreasureTile>()) {
					for (int inventoryIndex = 0; inventoryIndex < Main.rand.Next(13, 15); inventoryIndex++) {
						if (chest.item[inventoryIndex].type == 0 && inventoryIndex == 0) {
							chest.item[inventoryIndex].SetDefaults(19);
							chest.item[inventoryIndex].stack = Main.rand.Next(10,35);
						}
						if (chest.item[inventoryIndex].type == 0 && inventoryIndex == 1) {
							chest.item[inventoryIndex].SetDefaults(21);
							chest.item[inventoryIndex].stack = Main.rand.Next(10,35);
						}
						if (chest.item[inventoryIndex].type == 0 && inventoryIndex == 2) {
							chest.item[inventoryIndex].SetDefaults(706);
							chest.item[inventoryIndex].stack = Main.rand.Next(10,35);
						}
						if (chest.item[inventoryIndex].type == 0 && inventoryIndex == 3) {
							chest.item[inventoryIndex].SetDefaults(72);
							chest.item[inventoryIndex].stack = Main.rand.Next(10,99);
						}
						if (chest.item[inventoryIndex].type == 0 && inventoryIndex == 4) {
							chest.item[inventoryIndex].SetDefaults(73);
							chest.item[inventoryIndex].stack = Main.rand.Next(1,35);
						}
						if (chest.item[inventoryIndex].type == 0 && inventoryIndex < Which) {
							chest.item[inventoryIndex].SetDefaults(ItemForChest[Main.rand.Next(1,104)]);
						}
						if (chest.item[inventoryIndex].type == 0 && inventoryIndex >= Which && inventoryIndex < 12) {
							chest.item[inventoryIndex].SetDefaults(OtherForChest[Main.rand.Next(1,10)]);
							chest.item[inventoryIndex].stack = Main.rand.Next(1,20);
						}
						if (chest.item[inventoryIndex].type == 0 && inventoryIndex >= 12) {
							chest.item[inventoryIndex].SetDefaults(SunkenTreasureExclus[Main.rand.Next(1,3)]);
						}
					}
				}
			}
				}
			}
			wofDead = false;
		}
		if(moonlordDead) {
			for (int k = 0; k < (int)((Main.maxTilesX * Main.maxTilesY) * 6E-05); k++) {
				int x = WorldGen.genRand.Next(0, Main.maxTilesX);
				int y = WorldGen.genRand.Next((int)Main.maxTilesY - 200, Main.maxTilesY);
				WorldGen.TileRunner(x, y, WorldGen.genRand.Next(5, 15), WorldGen.genRand.Next(2, 6), TileType<Volcanite>());
			}
			for (int k = 0; k < (int)((Main.maxTilesX * Main.maxTilesY) * 6E-04); k++) {
				int x = WorldGen.genRand.Next(0, Main.maxTilesX);
				int y = WorldGen.genRand.Next((int)0, 0 + 200);
				Tile tile = Framing.GetTileSafely(x, y);
				if (tile.active() && tile.type == TileID.Dirt)
				{
				WorldGen.TileRunner(x, y, WorldGen.genRand.Next(5, 15), WorldGen.genRand.Next(2, 6), TileType<Twilite>());
				}
			}
			Main.NewText("The depths of Hell rise and the sky has truly emerged.",255,255,255);
			moonlordDead = false;
			volcaniteGen = false;
		}
		if(golemDead) {
			for (int k = 0; k < (int)((Main.maxTilesX * Main.maxTilesY) * 6E-05); k++) {
				int x = WorldGen.genRand.Next(0, Main.maxTilesX);
				int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow + 200, Main.maxTilesY);
				Tile tile = Framing.GetTileSafely(x, y);
				if (tile.active() && tile.type == TileID.Crimstone)
				{
				WorldGen.TileRunner(x, y, WorldGen.genRand.Next(5, 15), WorldGen.genRand.Next(2, 6), TileType<Scarlet>());
				}
				if (tile.active() && tile.type == TileID.Ebonstone)
				{
				WorldGen.TileRunner(x, y, WorldGen.genRand.Next(5, 15), WorldGen.genRand.Next(2, 6), TileType<CursedOre>());
				}
			}
			Main.NewText("It spreads.",255,255,0);
			golemDead = false;
		}
		if(planteraDead) {
			for (int k = 0; k < (int)((Main.maxTilesX * Main.maxTilesY) * 6E-05); k++) {
				int x = WorldGen.genRand.Next(0, Main.maxTilesX);
				int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow + 200, Main.maxTilesY);
				Tile tile = Framing.GetTileSafely(x, y);
				if (tile.active() && tile.type == TileID.Pearlstone)
				{
				WorldGen.TileRunner(x, y, WorldGen.genRand.Next(5, 15), WorldGen.genRand.Next(2, 6), TileType<Crystal>());
				}
			}
			Main.NewText("The crystals are starting their new growth.",100,0,255);
			planteraDead = false;
		}
		}
		public override void PostWorldGen() {
			int toAdd = ModContent.ItemType<Items.SwordOfTheOcean>();
			int toAdd2 = ModContent.ItemType<Items.SwordOfTheJungle>();
			for (int chestIndex = 0; chestIndex < 1000; chestIndex++) {
				Chest chest = Main.chest[chestIndex];
				if (chest != null && Main.tile[chest.x, chest.y].type == TileID.Containers && Main.tile[chest.x, chest.y].frameX == 17 * 36) {
					for (int inventoryIndex = 0; inventoryIndex < 40; inventoryIndex++) {
						if (chest.item[inventoryIndex].type == 0) {
							chest.item[inventoryIndex].SetDefaults(toAdd);
							break;
						}
					}
				}
				if (chest != null && Main.tile[chest.x, chest.y].type == TileID.Containers && Main.tile[chest.x, chest.y].frameX == 10 * 36) {
					for (int inventoryIndex = 0; inventoryIndex < 40; inventoryIndex++) {
						if (chest.item[inventoryIndex].type == 0) {
							chest.item[inventoryIndex].SetDefaults(toAdd2);
							break;
						}
					}
				}
			}
		}
	}
}