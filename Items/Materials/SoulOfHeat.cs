using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Materials
{
	public class SoulOfHeat : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Soul of Heat");
		}

		public override void SetDefaults() 
		{
			item.width = 22;
			item.height = 28;
			item.value = 1000;
			item.rare = 5;
			item.maxStack = 999;
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(5, 4));
			ItemID.Sets.AnimatesAsSoul[item.type] = true;
			ItemID.Sets.ItemIconPulse[item.type] = true;
			ItemID.Sets.ItemNoGravity[item.type] = true;
		}
	}
}