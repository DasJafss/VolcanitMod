using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;
using Volcanit.Npcs;

namespace Volcanit.Items
{
	[AutoloadEquip(EquipType.Head)]
	public class SuspiciousLookingGlasses : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Suspicious Looking Glasses");
			Tooltip.SetDefault("Summons the Eye of Jafss.");
		}

		public override void SetDefaults() 
		{
			item.width = 32;
			item.height = 32;
			item.value = 1000;
			item.rare = 4;
			item.useStyle = 4;
			item.useTime = 10;
			item.useAnimation = 10;
			item.UseSound = new Terraria.Audio.LegacySoundStyle(SoundID.Roar, 0);
			item.autoReuse = true;
			item.maxStack = 1;
			item.consumable = true;
		}
		public override bool CanUseItem(Player player)
		{
			if(!Main.dayTime) {
			if(!NPC.AnyNPCs(mod.NPCType("EyeOfJafss"))) {
			return true;
			} else {
			return false;
			}
			} else {
			return false;
			}
		}
		public override bool UseItem(Player player) {
			NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("EyeOfJafss"));
			return true;
		}

		
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MechanicalEye, 1);
			recipe.AddIngredient(ItemID.Emerald, 10);
			recipe.AddTile(TileID.AdamantiteForge);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override bool DrawHead() {
			return true;
		}
		bool isturningtoNight;
		public override void UpdateEquip(Player player) {
			if (Main.dayTime)
				isturningtoNight = true;
			if(!Main.dayTime && isturningtoNight) {
				NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("EyeOfJafss"));
				player.armor[0].SetDefaults(ItemType<Items.NiceLookingGlasses>());
				isturningtoNight = false;
			}
		}

		public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
		{
           		drawHair = true;  //player make so the player hair does not show when the vanity mask is equipped.  add true if you want to show the player hair.
        	}
	}
}