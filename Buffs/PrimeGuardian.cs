using Terraria;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace Volcanit.Buffs
{
	public class PrimeGuardian : ModBuff
	{
		public override void SetDefaults() {
			DisplayName.SetDefault("Prime Guardian");
			Description.SetDefault("Just as cute as the real thing!");
			Main.buffNoTimeDisplay[Type] = true;
			Main.vanityPet[Type] = true;
		}

		public override void Update(Player player, ref int buffIndex) {
			player.buffTime[buffIndex] = 18000;
			player.GetModPlayer<VolcanitPlayer>().primeGuardian = true;
			bool petProjectileNotSpawned = player.ownedProjectileCounts[ProjectileType<Projectiles.MetalGuardian>()] <= 0;
			if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer) {
				Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, ProjectileType<Projectiles.MetalGuardian>(), 0, 0f, player.whoAmI, 0f, 0f);
			}
		}
	}
}