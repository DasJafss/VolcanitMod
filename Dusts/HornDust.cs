  
using Terraria;
using Terraria.ModLoader;

namespace Volcanit.Dusts
{
	public class HornDust : ModDust
	{
		public override void OnSpawn(Dust dust) {
			dust.velocity *= 0.4f;
			dust.noGravity = true;
			dust.noLight = true;
			dust.scale = 1.0f;
		}

		public override bool Update(Dust dust) {
			dust.position += dust.velocity;
			dust.rotation += dust.velocity.X * 0.15f;
			dust.scale -= 0.0025f;
			if (dust.scale < 0.02f) {
				dust.active = false;
			}
			return false;
		}
	}
}