using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MyMod.Items.Weapons.Melee
{
    public class DirtSword : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Dirt Sword");
            Tooltip.SetDefault("'It's a dirt sword. What did you expect?'");
        }

        public override void SetDefaults() {
            item.width = 27;
            item.height = 28;
            item.maxStack = 1;
            item.value = 100000;
            item.rare = ItemRarityID.Quest;
            item.damage = 100000;
            item.useAnimation = 5;
            item.useTime = 5;
            item.knockBack = 20;
            item.crit = 100;
            item.autoReuse = true;
            item.useStyle = ItemUseStyleID.SwingThrow;
            // Set other item.X values here
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("DirtBar"), 15);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}

/*
    item.width = 27;
    item.height = 28;
    item.maxStack = 1;
    item.value = 25;
    item.rare = ItemRarityID.White;
    item.damage = 3;
    item.useAnimation = 30;
    item.useTime = 30;
    item.knockBack = 1;
    item.crit = 2;
    item.useStyle = ItemUseStyleID.SwingThrow;
    // Set other item.X values here
*/
