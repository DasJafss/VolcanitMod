using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Volcanit.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class CobramailHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cobramail Helmet");
			Tooltip.SetDefault("SSSSSSSSS");
		}
		public override void SetDefaults()
		{
		item.width = 18;
		item.height = 18;
		item.value = 10000;
		item.rare = 8;
		item.defense = 20;
		}

		public override bool DrawHead() {
			return true;
		}
		public override bool IsArmorSet(Item head, Item body, Item legs) {
			return body.type == ItemType<CobramailChestplate>() && legs.type == ItemType<CobramailLeggings>();
		}

		public override void UpdateArmorSet(Player player) {
			player.setBonus = "Attacks give venom.";
			player.AddBuff(BuffID.WeaponImbueVenom, 1);
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null, "SnakeScale", 90);
			recipe.AddIngredient(null, "LizharditeBar", 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}