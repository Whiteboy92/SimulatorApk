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

        private double ArmorPenetration { get; set; }
        private double BonusHitRate { get; set; }
        private double BonusBasicDmg { get; set; }
        private double BonusCritChance { get; set; }
        private double StunChance { get; set; }
        private double ElementalDmg { get; set; }
        private double BonusDmg { get; set; }
        private double HighLvlMonsterDmg { get; set; }
        private double LowLvlMonsterDmg { get; set; }


        // RarityStats constructor
        private RarityStats(double armorPen, double hitRate, double basicDmg, double critChance, double stunChance,
                            double elementalDmg, double dmg, double highMonster, double lowMonster)
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

        private static double GetRandomNumber(double minimum, double maximum)
        {
            return random.NextDouble() * (maximum - minimum) + minimum;
        }


        public static void ClearInstances()
        {
            File.Delete(@"C:\Users\Admin\Desktop\WiT\Semestr 4\Solutions\SimulatorApk\dictRarity.txt");
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


        /* Creating rarity stats and values
        public static void CreateInstance(int x)
        {
            string strSeperator = ";";
            StringBuilder sbOutput = new();
            _ = new Random();

            for (var i = 1; i <= 5; i++)
            {
                RarityBonus["button" + i] = new RarityStats(
                    armorPen:        random.Next(12 * x, 22 * x),
                    hitRate:        random.Next(100 * x, 250 * x),
                    basicDmg:       random.Next(300 * x, 900 * x),
                    critChance:     random.Next(4 * x, 11 * x),
                    stunChance:     random.Next(1 * x, 4 * x),
                    elementalDmg:   random.Next(150 * x, 900 * x),
                    dmg:            random.Next(8 * x, 18 * x),
                    highMonster:    random.Next(17 * x, 29 * x),
                    lowMonster:     random.Next(14 * x, 32 * x));
            }
            sbOutput.AppendLine(string.Join(strSeperator, RarityBonus));
            File.AppendAllText(@"C:\Users\Admin\Desktop\WiT\Semestr 4\Solutions\SimulatorApk\dictRarity2.txt", sbOutput.ToString());
        }*/
    }
}
