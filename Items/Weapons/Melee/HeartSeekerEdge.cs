using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Items.Weapons.Melee
{
    public class HeartSeekerEdge : ModItem
    {
        public override void SetStaticDefaults() 
        {
            DisplayName.SetDefault("Heart Seeker Edge");
            Tooltip.SetDefault("For Lonely Souls <3");
        }

        public override void SetDefaults() 
        {
            item.damage = 75;
            item.melee = true;
            item.width = 17;
            item.height = 32;
            item.useTime = 30;
            item.useAnimation = 12;
            item.crit = 17;
            item.useStyle = 1;
            item.knockBack = 10;
            item.value = 10000;
            item.rare = 5;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }
    }
}