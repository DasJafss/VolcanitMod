using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Tiles
{
	public class CursedOre : ModTile
	{
		public override void SetDefaults()
		{
			TileID.Sets.Ore[Type] = true;
			Main.tileSpelunker[Type] = true;
			Main.tileValue[Type] = 801;
			Main.tileShine2[Type] = true;
			Main.tileShine[Type] = 975;
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = false;
			Main.tileLighted[Type] = true;
			Main.tileMergeDirt[Type] = true;
			drop = mod.ItemType("Cursed");
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Cursed Ore");
			AddMapEntry(new Color(10, 255, 0), name);
			mineResist = 4f;
			minPick = 210;
			dustType = 38;
		}
	}
}