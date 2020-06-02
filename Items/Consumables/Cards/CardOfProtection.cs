using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Consumables.Cards
{
	public class CardOfProtection : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Card of Protection");
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
			item.buffType = BuffID.Endurance;
			item.buffTime = 36000;
		}

		public override bool UseItem(Player player)
		{
		player.AddBuff(BuffID.Warmth, 36000);
		player.AddBuff(BuffID.Ironskin, 36000);
		player.AddBuff(BuffID.ObsidianSkin, 36000);
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