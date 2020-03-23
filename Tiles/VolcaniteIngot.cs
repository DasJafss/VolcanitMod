using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace Volcanit.Tiles
{
	public class VolcaniteIngot : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileFrameImportant[Type] = true;
			Main.tileSolidTop[Type] = true;
			Main.tileLighted[Type] = true;
			drop = mod.ItemType("VolcaniteBar");
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Volcanite Ingot");
			AddMapEntry(new Color(255, 0, 0), name);
		}
	}
}