using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Weapons.Magic
{
	public class CursedBook : ModItem
	{
		public override void SetStaticDefaults()
		{
            		DisplayName.SetDefault("Cursed Book");
            		Tooltip.SetDefault("Shoots out a stream of Cursed Flames.");
		}

		public override void SetDefaults()
		{
			item.useStyle = 5;
			item.damage = 70;
			item.width = 24;
			item.height = 24;
			item.useAnimation = 20;
			item.useTime = 20;
			item.magic = true;
			item.noMelee = true;
			item.shootSpeed = 3f;
			item.rare = 9;
			item.mana = 20;
			item.channel = true;
			item.autoReuse = true;
			item.UseSound = SoundID.Item20;
			item.shoot = mod.ProjectileType("CursedOrbB");
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "CursedBar", 17);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
