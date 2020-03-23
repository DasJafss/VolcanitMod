using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Tiles
{
	public class Crystal : ModTile
	{
		public override void SetDefaults()
		{
			TileID.Sets.Ore[Type] = true;
			Main.tileSpelunker[Type] = true;
			Main.tileValue[Type] = 805;
			Main.tileShine2[Type] = true;
			Main.tileShine[Type] = 975;
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileLighted[Type] = true;
			Main.tileBlendAll[Type] = true;
			drop = mod.ItemType("CrystalOre");
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Fiaryite Crystal");
			AddMapEntry(new Color(100, 0, 255), name);
			mineResist = 4f;
			minPick = 190;
			dustType = 1;
		}
	}
}