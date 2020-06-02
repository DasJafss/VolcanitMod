using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Weapons.Melee
{
	public class CalamitousDagger : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Calamitous Dagger");
		}

		public override void SetDefaults() 
		{
			item.damage = 300;
			item.melee = true;
			item.width = 70;
			item.height = 88;
			item.useTime = 13;
			item.useAnimation = 13;
			item.crit = 70;
			item.useStyle = 1;
			item.knockBack = 17;
			item.value = 150000;
			item.rare = 12;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CalamitousBar", 23);
			recipe.AddTile(null, "VolcanitAnvils");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}