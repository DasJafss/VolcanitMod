using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Volcanit.Projectiles;

namespace Volcanit.Items.Weapons.Throwables
{
	public class AlmightyHatchetItem : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Almighty Hatchet");
		}

		public override void SetDefaults()
        	{
            		item.useStyle = 5;
            		item.width = 30;
            		item.height = 30;
            		item.useAnimation = 12;
            		item.useTime = 12;
            		item.thrown = true;
            		item.shootSpeed = 3f;
            		item.knockBack = 2.5f;
            		item.damage = 150;
            		item.rare = 10;
            		item.channel = true;
            		item.noUseGraphic = true;
            		item.autoReuse = true;
            		item.UseSound = SoundID.Item1;
            		item.shoot = ModContent.ProjectileType<AlmightyHatchet>();
        	}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentVortex, 20);
			recipe.AddIngredient(ItemID.IceBlock, 150);
			recipe.AddTile(null, "VolcanitAnvils");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}