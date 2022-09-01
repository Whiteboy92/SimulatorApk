using System;
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
        }

        public Equipment GetRarity()
        {
            return SharedClass.RarityLvlValue;
        }

        private void ItemRarityMenu_Load(object sender, EventArgs e)
        {
            pbItemRarity.Image = SharedClass.ImageToDisplay;
            lbRarityDisplay.Text = SharedClass.RarityLvlValue.Rarity.ToString();
            RarityStats.CreateInstance();
        }
    }
}