using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Volcanit.Tiles
{
	public class BurnedStone : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileBlendAll[Type] = true;
			drop = mod.ItemType("BurnedStoneItem");
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("");
			AddMapEntry(new Color(100, 100, 100), name);
			dustType = 4;
		}
	}
}