using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Volcanit.Tiles
{
	public class CursedIngot : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileFrameImportant[Type] = true;
			Main.tileSolidTop[Type] = true;
			Main.tileLighted[Type] = true;
			drop = mod.ItemType("CursedBar");
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Cursed Ingot");
			AddMapEntry(new Color(10, 200, 0), name);
		}
	}
}