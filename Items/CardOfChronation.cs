using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items
{
	public class CardOfChronation : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Card of Chronation");
		}

		public override void SetDefaults() 
		{
			item.width = 32;
			item.height = 32;
			item.value = 10000;
			item.rare = 5;
			item.useStyle = 2;
			item.useTime = 10;
			item.useAnimation = 15;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.maxStack = 99;
			item.consumable = true;
			item.buffType = BuffID.Swiftness;
			item.buffTime = 36000;
		}

		public override bool UseItem(Player player)
		{
		Main.time += 43200;
		return true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "BlankCard", 1);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}