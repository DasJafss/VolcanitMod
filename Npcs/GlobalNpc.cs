using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Volcanit.Npcs
{
    public class GlobalNpc : GlobalNPC
    {

        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if (type == NPCID.Merchant)
            {
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.Consumables.Cheese>());
                nextSlot++;
            }
	    if (type == NPCID.Wizard)
            {
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.Materials.BlankCard>());
                nextSlot++;
            }
	    if (type == NPCID.Mechanic)
            {
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<Items.Consumables.Summoning.SuspiciousLookingTelescope>());
                nextSlot++;
            }
        }

	public override void NPCLoot(NPC npc)
        {
            if (npc.type == NPCID.FlyingSnake)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.Materials.SnakeScale>(), Main.rand.Next(10, 20));
            }
	    if (npc.type == NPCID.Golem)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.Materials.Bars.LizharditeBar>(), Main.rand.Next(30, 40));
            }
	    if (npc.type == NPCID.Plantera)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.Consumables.ManaBean>(), Main.rand.Next(3, 7));
            }
	    if (npc.type == 113)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.Equipables.SuspiciousLookingGlasses>());
            }
	    if (npc.type == 266)
            {
                Item.NewItem(npc.getRect(), ModContent.ItemType<Items.TileItems.BrainBlockItem>(), Main.rand.Next(20, 40));
            }
        }
    }
}