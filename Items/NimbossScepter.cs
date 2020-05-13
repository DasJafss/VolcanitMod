using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Volcanit.Projectiles;

namespace Volcanit.Items
{
	public class NimbossScepter : ModItem
	{
		public override void SetStaticDefaults()
		{
            		DisplayName.SetDefault("Cloud Scepter");
		}

		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.width = 36;
			item.damage = 80;
			item.height = 36;
			item.useAnimation = 20;
			item.useTime = 20;
			item.magic = true;
			item.shootSpeed = 1f;
			item.rare = 8;
			item.mana = 30;
			item.channel = true;
			item.noMelee = true;
			item.autoReuse = true;
			item.UseSound = SoundID.Item1;
			item.shoot = ModContent.ProjectileType<PlayerThunder>();
		}
	}
}
