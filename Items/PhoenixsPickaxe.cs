using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items
{
	public class PhoenixsPickaxe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Phoenix's Pickaxe");
			Tooltip.SetDefault("Swing it at your foes to make a quicker gettaway.");
		}

		public override void SetDefaults() 
		{
			item.damage = 40;
			item.melee = true;
			item.width = 46;
			item.pick = 230;
			item.height = 52;
			item.useTime = 25;
			item.useAnimation = 25;
			item.crit = 3;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 100000;
			item.rare = 6;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MoltenPickaxe, 1);
			recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
			recipe.AddIngredient(ItemID.Picksaw, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
			player.AddBuff(BuffID.Mining, 1800);
		}
	}
}