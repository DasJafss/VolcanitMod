using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Volcanit.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class VolcaniteHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Volcanite Headgear");
		}
		public override void SetDefaults()
		{
		item.width = 18;
		item.height = 18;
		item.value = 10000;
		item.rare = 10;
		item.defense = 30;
		}
		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == ItemType<VolcaniteChestplate>() && legs.type == ItemType<VolcaniteLeggings>();
		}

		public override void UpdateArmorSet(Player player) {
			player.setBonus = "Immune to fire\n+1% damage";
			player.allDamage += 0.2f;
			player.buffImmune[BuffID.OnFire] = true;
		}

		public override void UpdateEquip(Player player) {
			player.magicDamage += 0.1f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "VolcaniteBar", 20);
			recipe.AddTile(null, "VolcanitAnvils");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}