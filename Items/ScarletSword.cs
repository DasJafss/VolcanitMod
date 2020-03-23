using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items
{
	public class ScarletSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Scarlet Sword");
		}

		public override void SetDefaults() 
		{
			item.damage = 85;
			item.melee = true;
			item.width = 38;
			item.height = 38;
			item.useTime = 15;
			item.useAnimation = 15;
			item.crit = 20;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 100000;
			item.rare = 9;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ScarletBar", 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
			target.AddBuff(BuffID.OnFire, 10);
		}
	}
}