using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ObjectData;
using static Terraria.ModLoader.ModContent;

namespace Volcanit.Tiles
{
	public class SpecialCloud : ModTile
	{
		public override void SetDefaults() {
			Main.tileSpelunker[Type] = true;
			Main.tileShine2[Type] = true;
			Main.tileShine[Type] = 1250;
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileValue[Type] = 500;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
			TileObjectData.newTile.AnchorInvalidTiles = new[] { 127 };
			TileObjectData.newTile.StyleHorizontal = true;
			TileObjectData.newTile.LavaDeath = false;
			TileObjectData.addTile(Type);
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Suspicious Cloud");
			AddMapEntry(new Color(200, 200, 200), name);
			dustType = 263;
		}

		public override void KillMultiTile(int i, int j, int frameX, int frameY) {
			NPC.NewNPC(i * 16, j * 16 - 1024, ModContent.NPCType<Npcs.Nimboss>(), 0);
			Main.NewText("King Cloud has awoken!",171,64,255);
		}
	}
}