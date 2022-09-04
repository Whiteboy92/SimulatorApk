using System;
using System.Drawing;
using System.Windows.Forms;



namespace SimulatorApk
{
    public sealed partial class MainMenu : Form
    {
        //Fields
        private Form _activeForm;

        public MainMenu()
        {
            InitializeComponent();
        }


        private void MyMain_Load(object sender, EventArgs e)
        {
            Equipment.CreateInstance();
            btnUpgrade.Enabled = false;
            btnRarity.Enabled = false;
        }


        private void OpenChildForm(Form childForm)
        {
            _activeForm?.Close();

            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void EnableBtnUpgrade()
        {
            btnUpgrade.Enabled = true;
        }

        public void EnableBtnRarity()
        {
            btnRarity.Enabled = true;
        }


        private void BtnItemSelect_Click(object sender, EventArgs e)
        {
            btnItemSelect.Image = Image.FromFile(@"C:\Users\Admin\Desktop\Games\SimulatorApk\Equipment upgrade_files\Item_Selection_Click.png");
            OpenChildForm(new ItemSelectionMenu(this));
        }


        private void BtnUpgrade_Click(object sender, EventArgs e)
        {
            btnUpgrade.Image = Image.FromFile(@"C:\Users\Admin\Desktop\Games\SimulatorApk\Equipment upgrade_files\Item_Upgrade_Click.png");
            OpenChildForm(new ItemUpgradeMenu(this));
        }


        private void BtnRarity_Click(object sender, EventArgs e)
        {
            btnRarity.Image = Image.FromFile(@"C:\Users\Admin\Desktop\Games\SimulatorApk\Equipment upgrade_files\Item_Rarity_Click.png");
            OpenChildForm(new ItemRarityMenu());
        }


        private void BtnItemSelect_Leave(object sender, EventArgs e)
        {
            btnItemSelect.Image = Image.FromFile(@"C:\Users\Admin\Desktop\Games\SimulatorApk\Equipment upgrade_files\Item_Selection.png");
        }


        private void BtnUpgrade_Leave(object sender, EventArgs e)
        {
            btnUpgrade.Image = Image.FromFile(@"C:\Users\Admin\Desktop\Games\SimulatorApk\Equipment upgrade_files\Item_Upgrade.png");
        }


        private void BtnRarity_Leave(object sender, EventArgs e)
        {
            btnRarity.Image = Image.FromFile(@"C:\Users\Admin\Desktop\Games\SimulatorApk\Equipment upgrade_files\Item_Rarity.png");
        }
    }
}
