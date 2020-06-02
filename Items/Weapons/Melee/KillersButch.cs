using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Weapons.Melee
{
	public class KillersButch : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Killer's Butch");
			Tooltip.SetDefault("Foes this sword slices will start bleeding.");
		}

		public override void SetDefaults() 
		{
			item.damage = 195;
			item.melee = true;
			item.width = 104;
			item.height = 116;
			item.useTime = 50;
			item.useAnimation = 50;
			item.crit = 51;
			item.useStyle = 1;
			item.knockBack = 30;
			item.value = 100000;
			item.rare = 9;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ButchersChainsaw, 1);
			recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
			recipe.AddIngredient(ItemID.BreakerBlade, 1);
			recipe.AddTile(null, "VolcanitAnvils");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
			target.AddBuff(BuffID.Bleeding, 600);
		}
	}
}