using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;
using Volcanit.Items.TileItems;
using static Terraria.ModLoader.ModContent;

namespace Volcanit.Tiles
{
	public class VolcanitAnvils : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileValue[Type] = 500;
			Main.tileSolidTop[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style2x1);
			TileObjectData.newTile.StyleHorizontal = true;
			TileObjectData.newTile.LavaDeath = false;
			TileObjectData.newTile.DrawYOffset = -2;
			TileObjectData.newTile.StyleWrapLimit = 32;
			TileObjectData.newTile.CoordinateHeights = new int[] { 20 };
			TileObjectData.addTile(Type);
			dustType = 263;
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Anvil");
			AddMapEntry(new Color(100, 0, 255), name);
		}

		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			int item = 0;
			switch (frameX / 36)
			{
				case 0:
					item = ItemType<ScarletAnvilItem>();
					break;
				case 1:
					item = ItemType<CursedAnvilItem>();
					break;
			}
			if (item > 0)
			{
				Item.NewItem(i * 16, j * 16, 48, 48, item);
			}
		}
	}
}
