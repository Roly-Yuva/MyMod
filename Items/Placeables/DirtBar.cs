using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MyMod.Items.Placeables
{
    public class DirtBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("'Why would anyone make this?'");
        }

        public override void SetDefaults()
        {
            item.width = 17;
            item.height = 14;
            item.maxStack = 99;
            item.value = 0;
            item.rare = ItemRarityID.Gray;
            item.useAnimation = 15;
            item.useTime = 10;
            item.consumable = true;
            item.useTurn = true;
            item.autoReuse = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.createTile = mod.TileType("DirtBar");
            // Set other item.X values here
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 3);
            recipe.AddTile(TileID.Dirt);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
