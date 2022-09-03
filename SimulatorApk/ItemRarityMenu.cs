using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulatorApk
{
    public partial class ItemRarityMenu : Form
    {
        public ItemRarityMenu()
        {
            InitializeComponent();
        }


        private void ItemRarityMenu_Shown(object sender, EventArgs e)
        {
            _ = GetRarity();
            _ = GetItemId();
        }


        public Equipment GetRarity()
        {
            return SharedClass.RarityLvlValue;
        }

        public string GetItemId()
        {
            return SharedClass.ItemId;
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
            string x = SharedClass.ItemId;
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

            if (num <= 1 & num > 0)         //1%
            {
                SharedClass.RarityLvlValue.Rarity = 8;
            }
            else if (num <= 4 & num > 1)    //3%
            {
                SharedClass.RarityLvlValue.Rarity = 7; 
            }
            else if (num <= 9 & num > 4)    //5%
            {
                SharedClass.RarityLvlValue.Rarity = 6; 
            }
            else if (num <= 16 & num > 9)   //7%
            {
                SharedClass.RarityLvlValue.Rarity = 5; 
            }
            else if (num <= 26 & num > 16)  //10%
            {
                SharedClass.RarityLvlValue.Rarity = 4; 
            }
            else if (num <= 40 & num > 26)  //14%
            {
                SharedClass.RarityLvlValue.Rarity = 3; 
            }
            else if (num <= 58 & num > 40)  //18%
            {
                SharedClass.RarityLvlValue.Rarity = 2; 
            }
            else if (num <= 78 & num > 58)  //20%
            {
                SharedClass.RarityLvlValue.Rarity = 1; 
            }
            else if (num <= 100 & num > 78) //22%
            {
                SharedClass.RarityLvlValue.Rarity = 0; 
            }

            lbRarityDisplay.Text = SharedClass.RarityLvlValue.Rarity.ToString();

            DisplayRarityStats();
        }
    }
}