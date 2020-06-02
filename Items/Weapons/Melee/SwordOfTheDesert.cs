using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Volcanit.Projectiles;

namespace Volcanit.Items.Weapons.Meele
{
	public class SwordOfTheDesert : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Blade of the Desert");
			Tooltip.SetDefault("Sends a dust cloud forth to confuse your enemies!");
		}

		public override void SetDefaults() 
		{
			item.damage = 20;
			item.melee = true;
			item.width = 38;
			item.height = 54;
			item.useTime = 20;
			item.useAnimation = 20;
			item.crit = 11;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 100000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = ModContent.ProjectileType<DesertCloud>();
			item.shootSpeed = 4f;
		}
	}
}