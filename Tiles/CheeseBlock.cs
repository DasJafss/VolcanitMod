using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Volcanit.Tiles
{
	public class CheeseBlock : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;
			Main.tileLighted[Type] = true;
			Main.tileMergeDirt[Type] = true;
			drop = mod.ItemType("CheeseBlockItem");
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Cheese Block");
			AddMapEntry(new Color(200, 200, 000), name);
			dustType = 153;
		}
	}
}