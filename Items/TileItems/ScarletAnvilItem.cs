using Terraria.ID;
using Terraria.ModLoader;
using Volcanit.Tiles;
using static Terraria.ModLoader.ModContent;

namespace Volcanit.Items.TileItems
{
    public class ScarletAnvilItem : ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Scarlet Anvil");
		}

		public override void SetDefaults()
		{
			item.width = 32;
			item.height = 16;
			item.value = 1000;
			item.rare = 5;
			item.useStyle = 1;
			item.useTime = 10;
			item.useAnimation = 15;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.maxStack = 99;
			item.consumable = true;
			item.createTile = TileType<VolcanitAnvils>();
			item.placeStyle = 0;
		}

        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "ScarletBar", 12);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
        }
    }
}
