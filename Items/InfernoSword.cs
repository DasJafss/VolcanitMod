using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Volcanit.Items
{
	public class InfernoSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Inferno Sword");
			Tooltip.SetDefault("Ignites enemies forever on strike!");
		}

		public override void SetDefaults() 
		{
			item.damage = 195;
			item.melee = true;
			item.width = 108;
			item.height = 108;
			item.useTime = 30;
			item.useAnimation = 30;
			item.crit = 96;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = 1000000;
			item.rare = 11;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "Fieroblade", 1);
			recipe.AddIngredient(null, "HeroSword", 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override Color? GetAlpha(Color lightColor) {
			return Color.White; // So the item's sprite isn't affected by light
		}

		public override void MeleeEffects(Player player, Rectangle hitbox) {
			Vector2 position = player.RotatedRelativePoint(new Vector2(player.itemLocation.X + 12f * player.direction + player.velocity.X, player.itemLocation.Y - 14f + player.velocity.Y), true);
			Lighting.AddLight(position, 1f, 1f, 1f);
		}

		int hitCount = 0;
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {
			target.AddBuff(BuffID.OnFire, 360000);
			hitCount += 1;
			if (hitCount >= 5) {
				player.AddBuff(BuffID.Inferno, 100);
				hitCount = 0;
			}
		}
	}
}