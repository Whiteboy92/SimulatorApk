using System;
using System.Drawing;
using System.Windows.Forms;


namespace SimulatorApk
{
    public partial class ItemSelectionMenu : Form
    {
        //fields
        private readonly MainMenu _mainMenu;


        public ItemSelectionMenu(MainMenu mainMenu)
        {
            InitializeComponent();
            //Equipment.EqList();
            _mainMenu = mainMenu;
        }
        

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            if (sender is not Button button) return;
            button.BackColor = Color.FromArgb(46, 51, 73);
        }


        private void BtnRollValues_Click(object sender, EventArgs e)
        {
            var x = SharedClass.ItemId;
            Equipment.ClearInstancesOne();
            Equipment.CreateInstance(x);
            BtnViewStats_Click(sender);
        }

        private void BtnViewStats_Click(object sender)
        {
            tbItemStats.Text = null;
            btnRollValues.Enabled = true;

            if (sender is not Button button) return;
            var toolTip = new ToolTip();
            var caption = Equipment.Equipments[button.Name];

            toolTip.SetToolTip(tbItemStats, caption.ToString());
            tbItemStats.Text = caption.ToString();
            button.BackColor = Color.Blue;
        }


        private void BtnViewStats_Click2(object sender, EventArgs e)
        {
            tbItemStats.Text = null;
            btnRollValues.Enabled = true;

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
            _mainMenu.EnableBtnUpgrade();
        }
    }
}