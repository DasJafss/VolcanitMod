using Terraria.ModLoader;
using System;
using Terraria;
using System.Collections.Generic;
using Terraria.UI;
using Microsoft.Xna.Framework.Graphics;
using System.Reflection;
using Microsoft.Xna.Framework;
using Volcanit.Items.Consumables.Summoning;
using Volcanit.Items.Armor;
using Volcanit.Items.Materials;
using Volcanit.Items.Equipables;
using Volcanit.Items.Weapons.Yoyos;
using Volcanit.Items.Weapons.Throwables;
using Volcanit.Items.Weapons.Melee;
using Volcanit.Items.Consumables;
using Volcanit.Items.Consumables.Hearts;
using Volcanit.Items.Weapons.Magic;

namespace Volcanit
{
	public class Volcanit : Mod
	{

		public static Mod mod;
		
		private static float lifePerHeart = 20f;

		public Volcanit()
		{
			mod = this;
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
					ModContent.ItemType<SuspiciousLookingTelescope>(),
					0,
					new List<int> {ModContent.ItemType<StarshadeSlicer>(), ModContent.ItemType<PainStarDX>(), ModContent.ItemType<StarShard>(), ModContent.ItemType<Starshot>()},
					"Buy [i:" + ModContent.ItemType<SuspiciousLookingTelescope>() + "] from the Mechanic and use it.",
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
					ModContent.ItemType<SuspiciousLookingGlasses>(),
					ModContent.ItemType<MaskOfJafss>(),
					new List<int> {ModContent.ItemType<SightOfJafss>(), ModContent.ItemType<HeroSword>()},
					"Craft [i:" + ModContent.ItemType<SuspiciousLookingGlasses>() + "] and use it.",
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
					ModContent.ItemType<HeatMeat>(),
					ModContent.ItemType<HellianeFleshlingMask>(),
					new List<int> {ModContent.ItemType<SoulOfHeat>(), ModContent.ItemType<LavacaHeart>(), ModContent.ItemType<StarShard>(), ModContent.ItemType<MagmazineSaber>(), ModContent.ItemType<MagmaticClinger>(), ModContent.ItemType<HellianeDisk>()},
					"Craft [i:" + ModContent.ItemType<HeatMeat>() + "] and use it.",
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
					ModContent.ItemType<SandtronMask>(),
					new List<int> {ModContent.ItemType<SandScale>(), ModContent.ItemType<EnchantedKnives>(), ModContent.ItemType<EnchantedKatana>(), ModContent.ItemType<SleepPowder>()},
					"Catch [i:" + ModContent.ItemType<Npcs.SandWormItem>() + "] during a Hardmode sandstorm and use it.",
					"Dune Eater has eaten the sand!",
					"Volcanit/Npcs/Sandtron_Checklist",
					"Volcanit/Npcs/Sandtron_Head_Boss");
				bossChecklist.Call(
					"AddBoss",
					10.5f,
					ModContent.NPCType<Npcs.Nimboss>(),
					this,
					"Nimboss",
					(Func<bool>)(() => VolcanitWorld.downedCloud),
					0,
					0,
					ModContent.ItemType<NimbossScepter>(),
					"Break a Suspicious Cloud, which fall randomly after Golem is defeated.",
					"Nimboss is flying out!",
					"Volcanit/Npcs/Nimboss",
					"Volcanit/Npcs/Nimboss_Head_Boss");
			}
        }

        public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
        {
            var heartLayer = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Inventory"));
			var heartState = new LegacyGameInterfaceLayer("Volcanit: UI",
				delegate
				{
					DrawHearts(Main.spriteBatch);
					return true;
				},  
				InterfaceScaleType.UI);
			layers.Insert(heartLayer, heartState);
        }

		private float timer = 0.0f;
        private int currentState = 0;
		public void DrawHearts(SpriteBatch batch)
		{
			lifePerHeart = 20f;
            var lifeForHeart = Main.player[Main.myPlayer].statLifeMax / 20;
            var lifeForLavacaHeart = (int)((Main.player[Main.myPlayer].statLifeMax2 - 500) / 10f);
            if (lifeForLavacaHeart < 0)
                lifeForLavacaHeart = 0;
            if (lifeForLavacaHeart > 0)
            {
                lifeForHeart = Main.player[Main.myPlayer].statLifeMax / (20 + lifeForLavacaHeart / 4);
                lifePerHeart = (float)Main.player[Main.myPlayer].statLifeMax / 20f;
            }
            var playerLife = Main.player[Main.myPlayer].statLifeMax2 - Main.player[Main.myPlayer].statLifeMax;
            lifePerHeart += (float)(playerLife / lifeForHeart);
            var hearts = (int)((double)Main.player[Main.myPlayer].statLifeMax2 / (double)lifePerHeart);
            if (hearts >= 10)
                hearts = 10;
            for (int oneHeart = 1; oneHeart < (int)((double)Main.player[Main.myPlayer].statLifeMax2 / (double)lifePerHeart) + 1; ++oneHeart)
            {
                var scale = 1f;
                var checkDrawPos = false;
                var statLife = 0;
                if ((double)Main.player[Main.myPlayer].statLife >= (double)oneHeart * (double)lifePerHeart)
                {
                    statLife = 255;
                    if ((double)Main.player[Main.myPlayer].statLife == (double)oneHeart * (double)lifePerHeart)
                        checkDrawPos = true;
                }
                else
                {
                    float checkOwnLifeForDraw = ((float)Main.player[Main.myPlayer].statLife - (float)(oneHeart - 1) * lifePerHeart) / lifePerHeart;
                    statLife = (int)(30.0 + 225.0 * (double)checkOwnLifeForDraw);
                    if (statLife < 30)
                        statLife = 30;
                    scale = (float)((double)checkOwnLifeForDraw / 4.0 + 0.75);
                    if ((double)scale < 0.75)
                        scale = 0.75f;
                    if ((double)checkOwnLifeForDraw > 0.0)
                        checkDrawPos = true;
                }
                if (checkDrawPos)
                    scale += Main.cursorScale - 1.0f;
                var x = 0;
                var y = 0;
                if (oneHeart > 10)
                {
                    x -= 260;
                    y += 26;
                }
                var a = (int)((double)statLife * 0.9);
                int startX;
                var info = typeof(Main).GetField("UI_ScreenAnchorX",
                BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static);
                startX = (int)info.GetValue(null);
                ++timer;
                if (timer % 80f == 0f) currentState += 1;
                if (timer >= 80f) timer = 0.0f;
                if (currentState > 2) currentState = 0;
                if (!Main.player[Main.myPlayer].ghost)
                {
					if (lifeForLavacaHeart > 0)
                    {
                        --lifeForLavacaHeart;
                        var texture2 = mod.GetTexture("Misc/LavacaHeart");
                        batch.Draw(texture2, new Vector2((float)(500 + 26 * (oneHeart - 1) + x + startX + texture2.Width / 2), (float)(32.0 + ((double)texture2.Height - (double)texture2.Height * (double)scale) / 2.0) + (float)y + (float)(texture2.Height / 2)), new Rectangle?(new Rectangle(0, 0, texture2.Width, texture2.Height)), new Color(statLife, statLife, statLife, a), 0.0f, new Vector2((float)(texture2.Width / 2), (float)(texture2.Height / 2)), scale, SpriteEffects.None, 0.0f);
                    }
                }
            }
		}
    }
}