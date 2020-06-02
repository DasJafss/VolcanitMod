using Terraria.ID;
using Terraria.ModLoader;
using Volcanit.Projectiles;

namespace Volcanit.Items.Weapons.Melee
{
	public class SwordOfTheOcean : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Blade of the Ocean");
			Tooltip.SetDefault("Sends a mighty wave forth to hit your enemies!");
		}

		public override void SetDefaults() 
		{
			item.damage = 20;
			item.melee = true;
			item.width = 48;
			item.height = 56;
			item.useTime = 20;
			item.useAnimation = 20;
			item.crit = 11;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 100000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<Wave>();
			item.shootSpeed = 4f;
		}
	}
}