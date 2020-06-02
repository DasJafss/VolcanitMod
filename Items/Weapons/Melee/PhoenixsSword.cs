using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Weapons.Meele
{
	public class PhoenixsSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Phoenix's Sword");
			Tooltip.SetDefault("With each swing a burst of fire flies out!");
		}

		public override void SetDefaults() 
		{
			item.damage = 93;
			item.melee = true;
			item.width = 46;
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
			recipe.AddIngredient(ItemID.FieryGreatsword, 1);
			recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
			recipe.AddIngredient(ItemID.TheHorsemansBlade, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
			target.AddBuff(BuffID.OnFire, 240);
		}
	}
}