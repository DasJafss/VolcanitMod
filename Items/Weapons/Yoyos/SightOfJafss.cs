using Volcanit.Projectiles;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Weapons.Yoyos
{
	public class SightOfJafss : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Sight of Jafss");
            Tooltip.SetDefault("Smells like tears.");

			ItemID.Sets.Yoyo[item.type] = true;
			ItemID.Sets.GamepadExtraRange[item.type] = 15;
			ItemID.Sets.GamepadSmartQuickReach[item.type] = true;
		}

		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.width = 36;
			item.height = 36;
			item.useAnimation = 4;
			item.useTime = 4;
			item.shootSpeed = 16f;
			item.knockBack = 2.5f;
			item.damage = 50;
			item.rare = 5;
			item.melee = true;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.UseSound = SoundID.Item1;
			item.shoot = ModContent.ProjectileType<SightOfJafssproj>();
		}
	}
}
