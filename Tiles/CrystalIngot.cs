using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Volcanit.Tiles
{
	public class CrystalIngot : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileFrameImportant[Type] = true;
			Main.tileSolidTop[Type] = true;
			Main.tileLighted[Type] = true;
			drop = mod.ItemType("CrystalBar");
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Fiaryite Ingot");
			AddMapEntry(new Color(200, 0, 50), name);
		}
	}
}