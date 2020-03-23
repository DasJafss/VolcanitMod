using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items
{
	public class TheVolcanit : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("The Volcanit");
			Tooltip.SetDefault("This blade is legendary,\nuntouched by any mere peasant,\nor even legends for that matter.");
		}

		public override void SetDefaults() 
		{
			item.damage = 293;
			item.melee = true;
			item.width = 46;
			item.height = 52;
			item.useTime = 25;
			item.useAnimation = 25;
			item.crit = 46;
			item.useStyle = 1;
			item.knockBack = 15;
			item.value = 100000;
			item.rare = 11;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "InfernoSword", 1);
			recipe.AddIngredient(null, "VolcaniteBar", 30);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
			target.AddBuff(BuffID.OnFire, 1000000);
		}
	}
}