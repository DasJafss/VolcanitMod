using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Weapons.Magic
{
	public class StaffOfExplosion : ModItem
	{
		public override void SetStaticDefaults()
		{
            		DisplayName.SetDefault("Staff of Explosion");
            		Tooltip.SetDefault("Shoots out literal bombs, be cautious while using.");
		}

		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.width = 24;
			item.height = 24;
			item.useAnimation = 20;
			item.useTime = 20;
			item.magic = true;
			item.shootSpeed = 3f;
			item.rare = 6;
			item.mana = 20;
			item.channel = true;
			item.autoReuse = true;
			item.UseSound = SoundID.Item1;
			item.shoot = 37;
		}
	}
}
