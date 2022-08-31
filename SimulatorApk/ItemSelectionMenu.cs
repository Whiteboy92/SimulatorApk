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
            Equipment.EqList();
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
        }

        private void BtnViewStats_Click(object sender, EventArgs e)
        {
            tbItemStats.Text = null;
            if (sender is not Button button) return;
            var toolTip = new ToolTip();
            var caption = Equipment.Equipments[button.Name];
            toolTip.SetToolTip(tbItemStats, caption.ToString());
            tbItemStats.Text = caption.ToString();
            button.BackColor = Color.Blue;

            
            SharedClass.ImageToDisplay = button.Image;
        }


        private void BtnSelectItem_Click(object sender, EventArgs e)
        {
            //SharedClass.ImageToDisplay = MyImageToDisplay;
        }

        private void ItemSelectionMenu_Load(object sender, EventArgs e)
        {

        }
    }
    
}