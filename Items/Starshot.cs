using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Volcanit.Projectiles;

namespace Volcanit.Items
{
	public class Starshot : ModItem
	{
		public override void SetStaticDefaults()
		{
            		DisplayName.SetDefault("Starshot");
		}

		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.width = 24;
			item.damage = 25;
			item.height = 24;
			item.useAnimation = 20;
			item.useTime = 20;
			item.magic = true;
			item.shootSpeed = 16f;
			item.rare = 3;
			item.mana = 10;
			item.channel = true;
			item.noMelee = true;
			item.autoReuse = true;
			item.UseSound = SoundID.Item1;
			item.shoot = ModContent.ProjectileType<SmallStarPlayer>();
		}
		
		/*public override Vector2? HoldoutOffset() { return new Vector2(10, 0); }*/
	}
}
