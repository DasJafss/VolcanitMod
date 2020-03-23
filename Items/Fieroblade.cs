using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items
{
	public class Fieroblade : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Fieroblade");
			Tooltip.SetDefault("Ignites enemies for 1 minute on strike!");
		}

		public override void SetDefaults() 
		{
			item.damage = 170;
			item.melee = true;
			item.width = 108;
			item.height = 108;
			item.useTime = 30;
			item.useAnimation = 30;
			item.crit = 21;
			item.useStyle = 1;
			item.knockBack = 0;
			item.value = 150000;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentSolar, 10);
			recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
			recipe.AddIngredient(null, "PhoenixsSword", 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
			target.AddBuff(BuffID.OnFire, 3600);
		}
	}
}