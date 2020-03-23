using Volcanit.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items
{
	public class EnchantedKnives : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Enchanted Knife");
            Tooltip.SetDefault("Homing.");
		}

		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.width = 24;
			item.height = 24;
			item.useAnimation = 12;
			item.useTime = 12;
			item.thrown = true;
			item.shootSpeed = 3f;
			item.knockBack = 2.5f;
			item.damage = 50;
			item.rare = 5;
			item.channel = true;
			item.noUseGraphic = true;
			item.autoReuse = true;
			item.UseSound = SoundID.Item1;
			item.shoot = ModContent.ProjectileType<EnchantedKnife>();
		}
	}
}
