using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace MyMod.Tiles
{
	public class DirtBar : ModTile
	{
		public override void SetDefaults()
		{
            Main.tileShine[Type] = 0;
			Main.tileSolid[Type] = true;
            Main.tileSolidTop[Type] = true;
			Main.tileFrameImportant[Type] = true;
			dustType = 0;
			drop = mod.ItemType("DirtBar");

            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x1);
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.addTile(Type);

            AddMapEntry(new Color(189, 132, 66));
			// Set other values here
		}
	}
}
