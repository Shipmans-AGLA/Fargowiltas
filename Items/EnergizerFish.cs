using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;
using System.Linq;

namespace Fargowiltas.Items
{
	public class EnergizerFish : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fishy Energizer");
			Tooltip.SetDefault("'You feel content'");
		}
		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 999;
			item.rare = 1;
		}
		public override string Texture
		{
			get
			{
				return "Fargowiltas/Items/Placeholder";
			}
		}
	}
}