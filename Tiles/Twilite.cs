using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Tiles
{
	public class Twilite : ModTile
	{
		public override void SetDefaults()
		{
			TileID.Sets.Ore[Type] = true;
			Main.tileSpelunker[Type] = true;
			Main.tileValue[Type] = 830;
			Main.tileShine2[Type] = true;
			Main.tileShine[Type] = 975;
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileLighted[Type] = true;
			Main.tileBlendAll[Type] = true;
			drop = mod.ItemType("TwiliteOre");
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Twilite");
			AddMapEntry(new Color(255, 255, 0), name);
			mineResist = 4f;
			minPick = 235;
		}
	}
}