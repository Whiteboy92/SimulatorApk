using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulatorApk
{
    public sealed partial class ItemRarityMenu : Form
    {
        public ItemRarityMenu()
        {
            InitializeComponent();
        }
        

        private void ItemRarityMenu_Load(object sender, EventArgs e)
        {
            pbItemRarity.Image = SharedClass.ImageToDisplay;
            lbRarityDisplay.Text = SharedClass.RarityLvlValue.Rarity.ToString();

            DisplayRarityStats();
        }


        private async void BtnChangeRarity_Click(object sender, EventArgs e)
        {
            tbRarityBonuses.Text = null;
            lbRarityDisplay.BackColor = Color.FromArgb(46, 51, 73);
            await Task.Delay(50);
            Gambling();
            lbRarityDisplay.BackColor = Color.Green;
            RarityStats.ClearInstances2();
            var x = SharedClass.ItemId;
            RarityStats.CreateInstance(x);
            DisplayRarityStats();
        }


        private void DisplayRarityStats()
        {
            Name = SharedClass.ItemId;
            var caption = RarityStats.RarityBonus[Name];
            tbRarityBonuses.Text = caption.ToString();
        }


        //Gambling for new rarity of an Item
        private void Gambling()
        {
            var random = new Random();
            var num = random.Next(1, 100);

            SharedClass.RarityLvlValue.Rarity = num switch
            {
                //1%
                <= 1 and > 0 => 8,
                //3%
                <= 4 and > 1 => 7,
                //5%
                <= 9 and > 4 => 6,
                //7%
                <= 16 and > 9 => 5,
                //10%
                <= 26 and > 16 => 4,
                //14%
                <= 40 and > 26 => 3,
                //18%
                <= 58 and > 40 => 2,
                //20%
                <= 78 and > 58 => 1,
                //22%
                <= 100 and > 78 => 0,
                _ => SharedClass.RarityLvlValue.Rarity
            };

            lbRarityDisplay.Text = SharedClass.RarityLvlValue.Rarity.ToString();
            DisplayRarityStats();
        }
    }
}