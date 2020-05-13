using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items
{
	public class CardOfTransportation : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Card of Transportation");
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
			item.autoReuse = false;
			item.maxStack = 99;
			item.consumable = true;
		}

		public override bool UseItem(Player player)
		{
		player.position.X = Main.MouseWorld.X;
		player.position.Y = Main.MouseWorld.Y;
		for(int i = 0; i < 30; i++) {
			Dust.NewDust(player.position, player.width, player.height, 21);
		}
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