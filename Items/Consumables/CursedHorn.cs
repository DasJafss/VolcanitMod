using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Consumables
{
	public class CursedHorn : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Horn of Revival");
			Tooltip.SetDefault("Returns you to the previous point of death.");
		}

		public override void SetDefaults() 
		{
			item.width = 38;
			item.height = 42;
			item.value = 1000000;
			item.rare = 6;
			item.useStyle = 4;
			item.useTime = 10;
			item.useAnimation = 15;
			item.UseSound = SoundID.Item65;
			item.autoReuse = false;
			item.maxStack = 1;
		}

		public override bool CanUseItem(Player player) {
			if (player.lastDeathPostion.X==0f && player.lastDeathPostion.Y==0f) {
				return false;
			}
			else {
				return true;
			}
		}

		public override bool UseItem(Player player)
		{
		player.position.X = player.lastDeathPostion.X;
		player.position.Y = player.lastDeathPostion.Y - 32f;
		for(int i = 0; i < 30; i++) {
			Dust.NewDust(player.position, player.width, player.height, ModContent.DustType<Dusts.HornDust>());
		}
		return true;
		}
	}
}