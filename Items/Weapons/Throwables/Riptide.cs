using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;
//Special thanks to IDGCaptainRussia94
namespace Volcanit.Items.Weapons.Throwables
{
	public class Riptide : ModItem
	{
        public static float throwspeed = 5.00f;
        public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Riptide");
			Tooltip.SetDefault("Throws you in the direction when raining with access to the sky or when in liquids");
		}

        public override void SetDefaults()
        {
            item.width = 56;
            item.height = 56;
            item.damage = 32;
            item.melee = true;
            item.noMelee = true;
            item.useTurn = true;
            item.noUseGraphic = true;
            item.useAnimation = 40;
            item.useTime = 40;
            item.useStyle = 5;
            item.knockBack = 6f;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
            item.maxStack = 1;
            item.value = 100000;
            item.rare = 6;
            item.shoot = mod.ProjectileType("RiptideProj");
            item.shootSpeed = 96f;
        }
	}

    public class RiptideProj : ModProjectile
    {

        bool mousecursor;

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Riptide");
        }

        public override string Texture
        {
            get { return ("Volcanit/Items/Weapons/Throwables/Riptide"); }
        }

        public override void SetDefaults()
        {
            projectile.width = 30;
            projectile.height = 30;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
            projectile.penetrate = -1;
            projectile.ownerHitCheck = true;
            projectile.scale = 1.2f;
            projectile.knockBack = 1f;
            projectile.aiStyle = 19;
            projectile.melee = true;
            projectile.timeLeft = 90;
        }

        public override void AI()
        {
            Player player = Main.player[projectile.owner];
            if (!player.active || player.dead)
            {
                projectile.Kill();
            }
            else
            {

                if (projectile.timeLeft > 3)
                {
                    bool skylinevis = (Collision.CanHitLine(new Vector2(player.Center.X, 0), 8, 8, new Vector2(player.Center.X, player.Center.Y), 8, 8));
                        if (player.wet || player.honeyWet || player.lavaWet || (skylinevis && Main.raining))
                    {
                        if (player.velocity.Y==0)
                        player.velocity = projectile.velocity / Riptide.throwspeed;
                        else
                        player.velocity += new Vector2(projectile.velocity.X/2f, projectile.velocity.Y/4f) / Riptide.throwspeed;


                    }
                }

                projectile.timeLeft = 2;

                float returnpercent = 0.5f;
                float percent = (((float)player.itemAnimationMax-(float)player.itemAnimation) / (float)player.itemAnimationMax);

                if (player.itemAnimation < player.itemAnimationMax * returnpercent)
                {
                    percent = (((float)player.itemAnimation) / ((float)player.itemAnimationMax));


                }

                projectile.Center = (player.Center - projectile.velocity) + (projectile.velocity * percent);

            }



            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 2.355f;
            if (projectile.spriteDirection == -1)
            {
                projectile.rotation -= 1.57f;
            }
            if (projectile.owner == Main.myPlayer)
            {
                mousecursor = (Main.MouseScreen.X - projectile.Center.X) > 0;
                projectile.direction = mousecursor.ToDirectionInt();
                projectile.netUpdate = true;


            }

        }
        public override bool PreDraw(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch, Color drawColor)
        {

            bool facingleft = projectile.direction < 0f;
            Microsoft.Xna.Framework.Graphics.SpriteEffects effect = SpriteEffects.FlipHorizontally;
            Texture2D texture = Main.projectileTexture[projectile.type];
            Vector2 origin = new Vector2(texture.Width * 0.5f, texture.Height * 0.5f);
            if (facingleft)
                Main.spriteBatch.Draw(texture, projectile.Center - Main.screenPosition, new Rectangle?(), drawColor, ((projectile.rotation - (float)Math.PI / 2) - (float)Math.PI / 2) + (facingleft ? (float)(1f * Math.PI) : 0f), origin, projectile.scale, effect, 0);
            if (!facingleft)
                Main.spriteBatch.Draw(texture, projectile.Center - Main.screenPosition, new Rectangle?(), drawColor, (projectile.rotation - (float)Math.PI / 2) + (facingleft ? (float)(1f * Math.PI) : 0f), origin, projectile.scale, SpriteEffects.None, 0);

            return false;
        }
    }


}