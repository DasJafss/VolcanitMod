using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Volcanit.Items
{
	internal class LavacaHeart : ModItem
	{

		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Permanently increases maximum life by 10");
		}

		public override void SetDefaults() {
			item.CloneDefaults(ItemID.LifeFruit);
		}

		public override bool CanUseItem(Player player) {
			return player.statLifeMax == 500 && player.GetModPlayer<VolcanitPlayer>().lavacaHearts < VolcanitPlayer.maxLavacaHearts;
		}

		public override bool UseItem(Player player) {
			player.statLifeMax2 += 10;
			player.statLife += 10;
			if (Main.myPlayer == player.whoAmI) {
				player.HealEffect(10, true);
			}
			player.GetModPlayer<VolcanitPlayer>().lavacaHearts += 1;
			return true;
		}
	}
}