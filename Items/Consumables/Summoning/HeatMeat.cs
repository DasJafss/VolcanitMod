using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Volcanit.Npcs;

namespace Volcanit.Items.Consumables.Summoning
{
	public class HeatMeat : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Heat Meat");
			Tooltip.SetDefault("Summons Helliane Fleshling.");
		}

		public override void SetDefaults() 
		{
			item.width = 32;
			item.height = 32;
			item.value = 10000;
			item.rare = 4;
			item.useStyle = 4;
			item.useTime = 10;
			item.useAnimation = 10;
			item.UseSound = SoundID.Item3;
			item.autoReuse = true;
			item.maxStack = 99;
			item.consumable = true;
		}
		public override bool CanUseItem(Player player)
		{
			if(Main.LocalPlayer.ZoneUnderworldHeight) {
			if(!NPC.AnyNPCs(mod.NPCType("HellianeFleshling"))) {
			return true;
			} else {
			return false;
			}
			} else {
			return false;
			}
		}
		public override bool UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("HellianeFleshling"));
			return true;
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WormFood, 1);
			recipe.AddIngredient(ItemID.Fireblossom, 10);
			recipe.AddIngredient(ItemID.Obsidian, 200);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}