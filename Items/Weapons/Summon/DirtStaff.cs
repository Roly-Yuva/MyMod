using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace MyMod.Items.Weapons.Summon
{
    public class DirtStaff : ModItem
    {
        public override void SetStaticDefaults() {
            DisplayName.SetDefault("Dirt Staff");
            Tooltip.SetDefault("Creates a dirt minion\n'Not sure why you would want this.'\nINCOMPLETE!!!");
            ItemID.Sets.GamepadWholeScreenUseRange[item.type] = true;
			ItemID.Sets.LockOnIgnoresCollision[item.type] = true;
        }

        public override void SetDefaults() {
            item.width = 25;
            item.height = 25;
            item.maxStack = 1;
            item.value = 50;
            item.rare = ItemRarityID.White;
            item.damage = 5;
            item.knockBack = 3;
            item.mana = 10;
            item.noMelee = true;
            item.summon = true;
            item.useAnimation = 45;
            item.useAnimation = 45;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.UseSound = SoundID.Item44;
            item.buffType = mod.BuffType("DirtyBuff");
            //item.shoot = mod.ProjectileType("DirtMinion");
        }

        public override void AddRecipes() {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("DirtBar"), 13);
            recipe.AddIngredient(ItemID.ManaCrystal);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack) {
            player.AddBuff(item.buffType, 9000, true);
            position = Main.MouseWorld;
            return true;
        }
    }
}
