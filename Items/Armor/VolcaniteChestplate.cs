using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class VolcaniteChestplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Volcanite Breastplate");
		}
		public override void SetDefaults()
		{
		item.width = 18;
		item.height = 18;
		item.value = 10000;
		item.rare = 10;
		item.defense = 35;
		}


		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "VolcaniteBar", 30);
			recipe.AddTile(null, "VolcanitAnvils");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}