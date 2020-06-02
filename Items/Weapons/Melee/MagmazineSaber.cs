using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Weapons.Meele
{
	public class MagmazineSaber : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Magmazine Saber");
			Tooltip.SetDefault("Ignites enemies hit.");
		}

		public override void SetDefaults() 
		{
			item.damage = 60;
			item.melee = true;
			item.width = 38;
			item.height = 42;
			item.useTime = 25;
			item.useAnimation = 25;
			item.crit = 5;
			item.useStyle = 3;
			item.knockBack = 6;
			item.value = 100000;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
			target.AddBuff(BuffID.OnFire, 180);
		}
	}
}