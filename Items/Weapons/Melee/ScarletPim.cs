using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Weapons.Melee
{
	public class ScarletPim : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Scarlet Pim");
		}

		public override void SetDefaults() 
		{
			item.damage = 50;
			item.melee = true;
			item.width = 46;
			item.pick = 220;
			item.hammer = 240;
			item.height = 52;
			item.useTime = 15;
			item.useAnimation = 15;
			item.crit = 3;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 100000;
			item.rare = 9;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ScarletBar", 23);
			recipe.AddTile(null, "VolcanitAnvils");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}