using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items
{
	public class SandScale : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Sand Scale");
		}

		public override void SetDefaults() 
		{
			item.width = 22;
			item.height = 28;
			item.value = 1000;
			item.rare = 5;
			item.maxStack = 999;
		}
	}
}