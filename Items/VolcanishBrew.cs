using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items
{
	public class VolcanishBrew : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Volcanish Brew");
		}

		public override void SetDefaults() 
		{
			item.width = 40;
			item.height = 40;
			item.value = 2500;
			item.rare = 5;
			item.useStyle = 2;
			item.useTime = 10;
			item.useAnimation = 15;
			item.UseSound = SoundID.Item3;
			item.autoReuse = true;
			item.maxStack = 99;
			item.consumable = true;
			item.buffType = mod.BuffType("MoltenStrength");
			item.buffTime = 1800;
		}
	}
}