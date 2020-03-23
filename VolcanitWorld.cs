using Volcanit.Tiles;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
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
		private void VolcanitOres(GenerationProgress progress) {
			progress.Message = "Volcanit Ores";
			for (int k = 0; k < (int)((Main.maxTilesX * Main.maxTilesY) * 6E-05); k++) {
				int x = WorldGen.genRand.Next(0, Main.maxTilesX);
				int y = WorldGen.genRand.Next((int)WorldGen.worldSurfaceLow, Main.maxTilesY);
				WorldGen.TileRunner(x, y, WorldGen.genRand.Next(5, 15), WorldGen.genRand.Next(2, 6), TileType<Volcanite>());
			}
		}
		public override void PostUpdate() {
		if(NPC.AnyNPCs(398)) {
			moonlordAlive = true;
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