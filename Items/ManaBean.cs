using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Volcanit.Items
{
	internal class ManaBean : ModItem
	{

		public override void SetStaticDefaults() {
			Tooltip.SetDefault("Permanently increases maximum mana by 5");
		}

		public override void SetDefaults() {
			item.CloneDefaults(ItemID.LifeFruit);
		}

		public override bool CanUseItem(Player player) {
			return player.statManaMax == 200 && player.GetModPlayer<VolcanitPlayer>().manaBeans < VolcanitPlayer.maxManaBeans;
		}

		public override bool UseItem(Player player) {
			player.statManaMax2 += 5;
			player.statMana += 5;
			player.GetModPlayer<VolcanitPlayer>().manaBeans += 1;
			return true;
		}
	}
}