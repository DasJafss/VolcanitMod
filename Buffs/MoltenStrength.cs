using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Volcanit.Buffs
{
	public class MoltenStrength : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Molten Strength");
			Description.SetDefault("Attacks do 2x damage.");
		}

		public override void Update(Player player, ref int buffIndex) {
			player.allDamage += 1.0f;
		}
	}
}