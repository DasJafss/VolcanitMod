using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Volcanit.Items.Weapons.Summoning
{
	public class MetalBoneKey : ModItem
	{
		public override void SetStaticDefaults() {
			DisplayName.SetDefault("Metal Bone Key");
			Tooltip.SetDefault("Summons a Prime Guardian to hang out with you or something.");
		}

		public override void SetDefaults() {
			item.CloneDefaults(ItemID.BoneKey);
			item.shoot = ProjectileType<Projectiles.MetalGuardian>();
			item.buffType = BuffType<Buffs.PrimeGuardian>();
			item.rare = 10;
		}

		public override void UseStyle(Player player) {
			if (player.whoAmI == Main.myPlayer && player.itemTime == 0) {
				player.AddBuff(item.buffType, 3600, true);
			}
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.BoneKey, 1);
			recipe.AddIngredient(ItemID.HallowedBar, 10);
			recipe.AddIngredient(null, "SoulOfHeat", 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
}