using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Volcanit.Npcs;

namespace Volcanit.Items.Equipables
{
	[AutoloadEquip(EquipType.Head)]
	public class NiceLookingGlasses : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Nice Looking Glasses");
			Tooltip.SetDefault("Something happened here, I'm not going to say what, \nbut it happened.");
		}

		public override void SetDefaults() 
		{
			item.width = 32;
			item.height = 32;
			item.value = 1000;
			item.rare = 5;
			item.autoReuse = true;
			item.maxStack = 99;
			item.consumable = true;
		}
		public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
		        {
            drawHair = true;  //player make so the player hair does not show when the vanity mask is equipped.  add true if you want to show the player hair.
        }
	}
}