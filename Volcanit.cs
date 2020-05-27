using Terraria.ModLoader;
using System;
using Terraria;
using System.Collections.Generic;
using System.IO;
using Terraria.UI;
using Microsoft.Xna.Framework.Graphics;
using System.Reflection;
using Microsoft.Xna.Framework;

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
					"Nimboss",
					(Func<bool>)(() => VolcanitWorld.downedCloud),
					0,
					0,
					ModContent.ItemType<Items.NimbossScepter>(),
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