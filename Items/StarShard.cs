using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Volcanit.Items
{
	internal class StarShard : ModItem
	{

		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Permanently increases defense by 1");
		}

		public override void SetDefaults() {
			item.CloneDefaults(ItemID.LifeFruit);
			item.rare = 3;
		}

		public override bool CanUseItem(Player player) {
			return player.GetModPlayer<VolcanitPlayer>().starShards < VolcanitPlayer.maxStarShards;
		}

		public override bool UseItem(Player player) {
			player.statDefense += 1;
			player.GetModPlayer<VolcanitPlayer>().starShards += 1;
			return true;
		}
	}
}