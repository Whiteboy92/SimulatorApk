using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SimulatorApk
{
    class RarityStats
    {
        static readonly Random random = new();

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


        // display rairty stats
        public override string ToString()
        {
            return " ArmorPenetration: " + ArmorPenetration + "\n" +
                   " BonusHitRate " + BonusHitRate + "\n" +
                   " BonusBasicDmg: " + BonusBasicDmg + "\n" +
                   " BonusCritChance: " + BonusCritChance + "%" + "\n" +
                   " StunChance: " + StunChance + "%" + "\n" +
                   " ElementalDmg: " + ElementalDmg + "\n" +
                   " BonusDmg: " + BonusDmg + "\n" +
                   " HighLvlMonsterDmg: " + HighLvlMonsterDmg + "\n" +
                   " LowLvlMonsterDmg: " + LowLvlMonsterDmg;
        }


        public static void ClearInstances()
        {
            File.Delete(@"C:\Users\Admin\Desktop\WiT\Semestr 4\Solutions\SimulatorApk\dictRarity.txt");
        }
        public static void ClearInstances2()
        {
            File.Delete(@"C:\Users\Admin\Desktop\WiT\Semestr 4\Solutions\SimulatorApk\dictRarity2.txt");
        }


        // Creating rarity stats and values
        public static void CreateInstance()
        {
            string strSeperator = ";";
            StringBuilder sbOutput = new();
            _ = new Random();

            for (var i = 1; i <= 5; i++)
            {
                RarityBonus["button"+i] = new RarityStats(
                    armorPen:       random.Next(12, 22),
                    hitRate:        random.Next(100, 250),
                    basicDmg:       random.Next(300, 900),
                    critChance:     random.Next(4, 11),
                    stunChance:     random.Next(1, 4),
                    elementalDmg:   random.Next(150, 900),
                    dmg:            random.Next(8, 18),
                    highMonster:    random.Next(17, 29),
                    lowMonster:     random.Next(14, 32));
            } 
            sbOutput.AppendLine(string.Join(strSeperator, RarityBonus));
            File.AppendAllText(@"C:\Users\Admin\Desktop\WiT\Semestr 4\Solutions\SimulatorApk\dictRarity.txt", sbOutput.ToString());
        }


        // Overload Changing rarity and stats for just selected item
        public static void CreateInstance(string s)
        {
            string strSeperator = ";";
            StringBuilder sbOutput = new();
            _ = new Random();

            int x = SharedClass.RarityLvlValue.Rarity;
            
                RarityBonus[s] = new RarityStats(
                    armorPen:       random.Next(12 * x, 22 * x),
                    hitRate:        random.Next(100 * x, 250 * x),
                    basicDmg:       random.Next(300 * x, 900 * x),
                    critChance:     random.Next(4 * x, 11 * x),
                    stunChance:     random.Next(1 * x, 4 * x),
                    elementalDmg:   random.Next(150 * x, 900 * x),
                    dmg:            random.Next(8 * x, 18 * x),
                    highMonster:    random.Next(17 * x, 29 * x),
                    lowMonster:     random.Next(14 * x, 32 * x));

            sbOutput.AppendLine(string.Join(strSeperator, RarityBonus));
            File.AppendAllText(@"C:\Users\Admin\Desktop\WiT\Semestr 4\Solutions\SimulatorApk\dictRarity2.txt", sbOutput.ToString());
        }
    }
}
