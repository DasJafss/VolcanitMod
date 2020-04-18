using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Volcanit.Tiles
{
	public class BrainBlock : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			Main.tileMergeDirt[Type] = true;
			drop = mod.ItemType("BrainBlockItem");
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Brain Block");
			AddMapEntry(new Color(256, 240, 240), name);
			dustType = 123;
		}
	}
}