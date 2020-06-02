using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Consumables
{
	public class SleepPowder : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Sleep Powder");
			Tooltip.SetDefault("Puts you to sleep for 3 hours.");
		}

		public override void SetDefaults() 
		{
			item.width = 26;
			item.height = 32;
			item.value = 1000;
			item.rare = 5;
			item.useStyle = 4;
			item.useTime = 10;
			item.useAnimation = 10;
			item.UseSound = SoundID.Item3;
			item.autoReuse = true;
			item.maxStack = 99;
			item.consumable = true;
		}
		public override bool UseItem(Player player)
		{
			Main.time += 10800;
			return true;
		}
	}
}