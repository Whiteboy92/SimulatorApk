using System;
using System.Drawing;
using System.Windows.Forms;



namespace SimulatorApk
{
    public sealed partial class MyMain : Form
    {
        //Fields
        private Form _activeForm;

        public MyMain()
        {
            InitializeComponent();
        }

        private void MyMain_Load(object sender, EventArgs e)
        {
            Equipment.CreateInstance();
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            _activeForm?.Close();

            _activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

 
        }


        private void BtnItemSelect_Click(object sender, EventArgs e)
        {
            btnItemSelect.Image = Image.FromFile(@"C:\Users\Admin\Desktop\WiT\Semestr 4\Solutions\SimulatorApk\\Item_Selection_Click.png");
            OpenChildForm(new ItemSelectionMenu(), sender);
        }

        private void BtnUpgrade_Click(object sender, EventArgs e)
        {
            btnUpgrade.Image = Image.FromFile(@"C:\Users\Admin\Desktop\WiT\Semestr 4\Solutions\SimulatorApk\\Item_Upgrade_Click.png");
            OpenChildForm(new ItemUpgradeMenu(), sender);
        }

        private void BtnRarity_Click(object sender, EventArgs e)
        {
            btnRarity.Image = Image.FromFile(@"C:\Users\Admin\Desktop\WiT\Semestr 4\Solutions\SimulatorApk\\Item_Rarity_Click.png");
            OpenChildForm(new ItemRarityMenu(), sender);
        }


        private void BtnItemSelect_Leave(object sender, EventArgs e)
        {
            btnItemSelect.Image = Image.FromFile(@"C:\Users\Admin\Desktop\WiT\Semestr 4\Solutions\SimulatorApk\\Item_Selection.png");
        }
        private void BtnUpgrade_Leave(object sender, EventArgs e)
        {
            btnUpgrade.Image = Image.FromFile(@"C:\Users\Admin\Desktop\WiT\Semestr 4\Solutions\SimulatorApk\\Item_Upgrade.png");
        }
        private void BtnRarity_Leave(object sender, EventArgs e)
        {
            btnRarity.Image = Image.FromFile(@"C:\Users\Admin\Desktop\WiT\Semestr 4\Solutions\SimulatorApk\\Item_Rarity.png");
        }
    }
}
