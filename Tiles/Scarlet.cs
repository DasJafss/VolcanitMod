using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Tiles
{
	public class Scarlet : ModTile
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
			drop = mod.ItemType("ScarletOre");
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Scarlet");
			AddMapEntry(new Color(200, 0, 50), name);
			mineResist = 4f;
			minPick = 210;
			dustType = 115;
		}
	}
}