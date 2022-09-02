using System;
using System.Drawing;
using System.Windows.Forms;


namespace SimulatorApk
{
    public partial class ItemSelectionMenu : Form
    {

        public ItemSelectionMenu()
        {
            InitializeComponent();
            //Equipment.EqList();
        }


        private void ItemSelectionMenu_Shown(object sender, EventArgs e)
        {
            _ = GetRarity();
        }
        

        public Equipment GetRarity()
        {
            return SharedClass.RarityLvlValue;
        }


        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is not Button button) return; 
            button.BackColor = Color.FromArgb(46, 51, 73);
        }


        private void BtnRollValues_Click(object sender, EventArgs e)
        {
            Equipment.ClearInstances();
            Equipment.CreateInstance();
            BtnViewStats_Click(sender, e);
        }


        private void BtnViewStats_Click(object sender, EventArgs e)
        {
            tbItemStats.Text = null;
            

            if (sender is not Button button) return;
            var toolTip = new ToolTip();
            var caption = Equipment.Equipments[button.Name];
            btnRollValues.Name = button.Name;
            toolTip.SetToolTip(tbItemStats, caption.ToString());
            tbItemStats.Text = caption.ToString();
            button.BackColor = Color.Blue;

            SharedClass.ImageToDisplay = button.Image;
            SharedClass.UpgradeLvlValue = Equipment.Equipments[button.Name];
            SharedClass.RarityLvlValue = Equipment.Equipments[button.Name];
            SharedClass.ItemId = button.Name;
        }
    }
}