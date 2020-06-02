using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Weapons.Meele
{
	public class NautilusSlicer : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Nautilus Slicer");
		}

		public override void SetDefaults() 
		{
			item.damage = 45;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.crit = 11;
			item.useStyle = 1;
			item.knockBack = 12;
			item.value = 10000;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
	}
}