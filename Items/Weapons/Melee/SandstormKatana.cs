using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Weapons.Melee
{
	public class SandstormKatana : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Sandstorm Katana");
			Tooltip.SetDefault("A katana of dusty sand!");
		}

		public override void SetDefaults() 
		{
			item.damage = 65;
			item.melee = true;
			item.width = 78;
			item.height = 88;
			item.useTime = 15;
			item.useAnimation = 15;
			item.crit = 15;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = 100000;
			item.rare = 6;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SandScale", 15);
			recipe.AddIngredient(ItemID.SpectreBar, 7);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
			target.AddBuff(BuffID.Confused, 360000);
		}
	}
}