using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Weapons.Meele
{
	public class VolcaniteKnife : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Volcanite Knife");
		}

		public override void SetDefaults() 
		{
			item.damage = 243;
			item.melee = true;
			item.width = 38;
			item.height = 38;
			item.useTime = 15;
			item.useAnimation = 15;
			item.crit = 46;
			item.useStyle = 3;
			item.knockBack = 15;
			item.value = 100000;
			item.rare = 10;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "VolcaniteBar", 20);
			recipe.AddTile(null, "VolcanitAnvils");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
			target.AddBuff(BuffID.OnFire, 10);
		}
	}
}