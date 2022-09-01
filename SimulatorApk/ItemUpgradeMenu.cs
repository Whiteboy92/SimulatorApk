using System.Drawing;
using System;
using System.Windows.Forms;
using System.Threading;

namespace SimulatorApk
{
    public partial class ItemUpgradeMenu : Form
    {
        public ItemUpgradeMenu()
        {
            InitializeComponent();
            UpgradeMats();
        }

        private void ItemUpgradeMenu_Load(object sender, EventArgs e)
        {
            pbItemUpgrade.Image = SharedClass.ImageToDisplay;
            UpgradeLvl.Text = "+ " + SharedClass.UpgradeLvlValue.UpgradeLevel.ToString();
        }

        private void ItemUpgradeMenu_Shown(object sender, EventArgs e)
        {
            _ = GetImage();
            _ = GetIndex();
        }
        Image GetImage()
        {
            while (SharedClass.ImageToDisplay == null)
            {
            }
            return SharedClass.ImageToDisplay;
        }

        public Equipment GetIndex()
        {
            return SharedClass.UpgradeLvlValue;
        }

        //Set basic materials needed
        private void UpgradeMats()
        {
            GoldNeeded.Text = 1500.ToString();
            GemNeeded.Text = 6.ToString();
            PowderNeeded.Text = 250.ToString();
        }

        private bool IsEqScroll
        {
            get
            {
                if (cBoxScroll.Checked == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private bool IsEqAmulet
        {
            get
            {
                if (cBoxAmulet.Checked == true)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        // Upgrade system
        // Stuff to be implemented
        // Eq Amulet and Scroll, destroying items, reset button
        private void BtnUpgrade_Click(object sender, EventArgs e)
        {
            if (IsEqScroll == false && IsEqAmulet == false)
            {
                var random = new Random();
                var num = random.Next(1, 1000);
                if(num < 1000/(1+ SharedClass.UpgradeLvlValue.UpgradeLevel*1.69))
                {
                    lbUpgradeOutput.BackColor = Color.FromArgb(46, 51, 73);
                    //Thread.Sleep(250);
                    SharedClass.UpgradeLvlValue.UpgradeLevel++;
                    lbUpgradeOutput.Text = "Upgrade succeed";
                    lbUpgradeOutput.BackColor = Color.Green;
                    UpgradeLvl.Text = "+ " + SharedClass.UpgradeLvlValue.UpgradeLevel.ToString();
                }
                else
                {
                    lbUpgradeOutput.BackColor = Color.FromArgb(46, 51, 73);
                    //Thread.Sleep(250);
                    lbUpgradeOutput.Text = "Upgrade failed";
                    lbUpgradeOutput.BackColor = Color.Red;
                }
            }

            else if (IsEqScroll == true && IsEqAmulet == false)
            {
                var random = new Random();
                var num = random.Next(1, 1000);
                if (num < 1000 / (1 + SharedClass.UpgradeLvlValue.UpgradeLevel * 1.69))
                {
                    SharedClass.UpgradeLvlValue.UpgradeLevel++;
                }
            }

            else if (IsEqScroll == false && IsEqAmulet == true)
            {
                var random = new Random();
                var num = random.Next(1, 1000);
                if (num < 1000 / (1 + SharedClass.UpgradeLvlValue.UpgradeLevel * 1.69))
                {
                    SharedClass.UpgradeLvlValue.UpgradeLevel++;
                }
            }

            else
            {
                var random = new Random();
                var num = random.Next(1, 1000);
                if (num < 1000 / (1 + SharedClass.UpgradeLvlValue.UpgradeLevel * 1.69))
                {
                    SharedClass.UpgradeLvlValue.UpgradeLevel++;
                }
            }
        }
    }
}


