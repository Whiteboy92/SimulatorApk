using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SimulatorApk
{
    class RarityStats
    {
        public static Dictionary<string, RarityStats> RarityBonus { get; } = new();

        private int ArmorPenetration { get; set; }
        private int BonusHitRate { get; set; }
        private int BonusBasicDmg { get; set; }
        private int BonusCritChance { get; set; }
        private int StunChance { get; set; }
        private int ElementalDmg { get; set; }
        private int BonusDmg { get; set; }
        private int HighLvlMonsterDmg { get; set; }
        private int LowLvlMonsterDmg { get; set; }

        // RarityStats constructor
        private RarityStats(int armorPen, int hitRate, int basicDmg, int critChance, int stunChance,
                            int elementalDmg, int dmg, int highMonster, int lowMonster)
        {
            ArmorPenetration = armorPen;
            BonusHitRate = hitRate;
            BonusBasicDmg = basicDmg;
            BonusCritChance = critChance;
            StunChance = stunChance;
            ElementalDmg = elementalDmg;
            BonusDmg = dmg;
            HighLvlMonsterDmg = highMonster;
            LowLvlMonsterDmg = lowMonster;
        }


        // display
        public override string ToString()
        {
            return " ArmorPenetration: " + ArmorPenetration + "\n" +
                   " BonusHitRate " + BonusHitRate + "\n" +
                   " BonusBasicDmg: " + BonusBasicDmg + "\n" +
                   " BonusCritChance: " + BonusCritChance + "\n" +
                   " StunChance: " + StunChance + "\n" +
                   " ElementalDmg: " + ElementalDmg + "\n" +
                   " BonusDmg: " + BonusDmg + "\n" +
                   " HighLvlMonsterDmg: " + HighLvlMonsterDmg + "\n" +
                   " LowLvlMonsterDmg: " + LowLvlMonsterDmg;
        }

        public static void CreateInstance()
        {
            string strSeperator = ";";
            StringBuilder sbOutput = new();
            var random = new Random();

            for (var i = 1; i <= 5; i++)
            {
                RarityBonus["Stat" + i] = new RarityStats(
                    armorPen: random.Next(12, 22),
                    hitRate: random.Next(100, 250),
                    basicDmg: random.Next(300, 900),
                    critChance: random.Next(4, 11),
                    stunChance: random.Next(1, 4),
                    elementalDmg: random.Next(150, 900),
                    dmg: random.Next(12, 22),
                    highMonster: random.Next(16, 30),
                    lowMonster: random.Next(16, 30));
            }
            sbOutput.AppendLine(string.Join(strSeperator, RarityBonus));
            File.AppendAllText(@"C:\Users\Admin\Desktop\WiT\Semestr 4\Solutions\SimulatorApk\dictRarity.txt", sbOutput.ToString());
        }
    }
}
