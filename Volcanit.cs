using Terraria.ModLoader;
using System;
using Terraria;
using System.Collections.Generic;
using System.IO;

namespace Volcanit
{
	public class Volcanit : Mod
	{
		public Volcanit()
		{
		}
		public override void PostSetupContent()
        {
            Mod bossChecklist = ModLoader.GetMod("BossChecklist");
			if(bossChecklist != null)
           	{
            			bossChecklist.Call(
					"AddBoss",
					5.5f,
					ModContent.NPCType<Npcs.Nova>(),
					this,
					"Nova",
					(Func<bool>)(() => VolcanitWorld.downedNova),
					ModContent.ItemType<Items.SuspiciousLookingTelescope>(),
					0,
					new List<int> {ModContent.ItemType<Items.StarshadeSlicer>(), ModContent.ItemType<Items.PainStarDX>(), ModContent.ItemType<Items.StarShard>(), ModContent.ItemType<Items.Starshot>()},
					"Buy [i:" + ModContent.ItemType<Items.SuspiciousLookingTelescope>() + "] from the Mechanic and use it.",
					"Nova is falling out!",
					"Volcanit/Npcs/Nova",
					"Volcanit/Npcs/Nova_Head_Boss");
				bossChecklist.Call(
					"AddBoss",
					7.5f,
					ModContent.NPCType<Npcs.EyeOfJafss>(),
					this,
					"Eye of Jafss",
					(Func<bool>)(() => VolcanitWorld.downedEOJ),
					ModContent.ItemType<Items.SuspiciousLookingGlasses>(),
					ModContent.ItemType<Items.Armor.MaskOfJafss>(),
					new List<int> {ModContent.ItemType<Items.SightOfJafss>(), ModContent.ItemType<Items.HeroSword>()},
					"Craft [i:" + ModContent.ItemType<Items.SuspiciousLookingGlasses>() + "] and use it.",
					"All have lost sight of the Eye of Jafss!",
					"Volcanit/Npcs/EyeOfJafss",
					"Volcanit/Npcs/EyeOfJafss_Head_Boss");
				bossChecklist.Call(
					"AddBoss",
					6.5f,
					ModContent.NPCType<Npcs.HellianeFleshling>(),
					this,
					"Helliane Fleshling",
					(Func<bool>)(() => VolcanitWorld.downedHelliane),
					ModContent.ItemType<Items.HeatMeat>(),
					ModContent.ItemType<Items.Armor.HellianeFleshlingMask>(),
					new List<int> {ModContent.ItemType<Items.SoulOfHeat>(), ModContent.ItemType<Items.LavacaHeart>(), ModContent.ItemType<Items.StarShard>(), ModContent.ItemType<Items.MagmazineSaber>(), ModContent.ItemType<Items.MagmaticClinger>(), ModContent.ItemType<Items.HellianeDisk>()},
					"Craft [i:" + ModContent.ItemType<Items.HeatMeat>() + "] and use it.",
					"The Helliane Fleshing got bored and left!",
					"Volcanit/Npcs/HellianeFleshling_Checklist",
					"Volcanit/Npcs/HellianeFleshling_Head_Boss");
				bossChecklist.Call(
					"AddBoss",
					8.5f,
					ModContent.NPCType<Npcs.Sandtron>(),
					this,
					"Dune Eater",
					(Func<bool>)(() => VolcanitWorld.downedSandtron),
					ModContent.ItemType<Npcs.SandWormItem>(),
					ModContent.ItemType<Items.Armor.SandtronMask>(),
					new List<int> {ModContent.ItemType<Items.SandScale>(), ModContent.ItemType<Items.EnchantedKnives>(), ModContent.ItemType<Items.EnchantedKatana>(), ModContent.ItemType<Items.SleepPowder>()},
					"Catch [i:" + ModContent.ItemType<Npcs.SandWormItem>() + "] during a Hardmode sandstorm and use it.",
					"Dune Eater has eaten the sand!",
					"Volcanit/Npcs/Sandtron_Checklist",
					"Volcanit/Npcs/Sandtron_Head_Boss");
				bossChecklist.Call(
					"AddBoss",
					10.5f,
					ModContent.NPCType<Npcs.Nimboss>(),
					this,
					"King Cloud",
					(Func<bool>)(() => VolcanitWorld.downedCloud),
					0,
					0,
					ModContent.ItemType<Items.NimbossScepter>(),
					"Break a Suspicious Cloud, which fall randomly after Golem is defeated.",
					"King Cloud is flying out!",
					"Volcanit/Npcs/Nimboss",
					"Volcanit/Npcs/Nimboss_Head_Boss");
			}
        }
	}
}