using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Volcanit.Npcs;

namespace Volcanit.Items
{
	public class SuspiciousLookingTelescope : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Suspicious Looking Telescope");
			Tooltip.SetDefault("Summons Nova, terror of the cosmos.");
		}

		public override void SetDefaults() 
		{
			item.width = 32;
			item.height = 32;
			item.value = 10000;
			item.rare = 3;
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
			if(!NPC.AnyNPCs(mod.NPCType("Nova"))) {
			return true;
			} else {
			return false;
			}
		}
		public override bool UseItem(Player player)
		{
			NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("Nova"));
			return true;
		}
	}
}