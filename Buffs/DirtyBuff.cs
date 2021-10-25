using Terraria;
using Terraria.ModLoader;

namespace MyMod.Buffs
{
    public class DirtyBuff : ModBuff
    {
        public override void SetDefaults() {
            DisplayName.SetDefault("Dirty");
            Description.SetDefault("You are dirty. You have decreased speed.\nINCOMPLETE!!!");
            Main.buffNoTimeDisplay[Type] = false;
            Main.debuff[Type] = true;
            Main.buffNoSave[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex) {
            player.buffTime[buffIndex] = 18000;
            player.moveSpeed *= (float)0.75;
            player.meleeSpeed *= (float)0.75;
        }
    }
}
