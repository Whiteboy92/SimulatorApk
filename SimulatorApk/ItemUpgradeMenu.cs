using System.Drawing;
using System;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace SimulatorApk
{
    public partial class ItemUpgradeMenu : Form
    {
        private readonly MainMenu _mainMenu;

        public ItemUpgradeMenu(MainMenu mainMenu)
        {
            _mainMenu = mainMenu;
            InitializeComponent();
            UpgradeMats();
        }


        private void ItemUpgradeMenu_Load(object sender, EventArgs e)
        {
            pbItemUpgrade.Image = SharedClass.ImageToDisplay;
            UpgradeLvl.Text = "+ " + SharedClass.UpgradeLvlValue.UpgradeLevel.ToString();
            lbUpgradeOutput.BackColor = Color.FromArgb(46, 51, 73);

            RarityStats.CreateInstance();
            _mainMenu.EnableBtnRarity();
        }


        //Set basic materials needed
        public void UpgradeMats()
        {
            int x = SharedClass.UpgradeLvlValue.UpgradeLevel;
            GoldNeeded.Text = ((1 + x) * 750).ToString();
            GemNeeded.Text = ((1 + x) * 12).ToString();
            PowderNeeded.Text = ((1 + x) * 150).ToString();
        }

        public bool IsEqScroll
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

        public bool IsEqAmulet
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


        private void ItemUpgradeMenu_Shown(object sender, EventArgs e)
        {
            _ = GetImage();
            _ = GetUpgradeLevel();
        }


        Image GetImage()
        {
            while (SharedClass.ImageToDisplay == null)
            {
            }
            return SharedClass.ImageToDisplay;
        }


        public Equipment GetUpgradeLevel()
        {
            return SharedClass.UpgradeLvlValue;
        }


        private void TotalMaterials()
        {
            int.TryParse(TotalGoldUsed.Text, out var i);
            int.TryParse(GoldNeeded.Text, out var j);
            TotalGoldUsed.Text = (j + i - 750).ToString();

            int.TryParse(TotalGemUsed.Text, out var o);
            int.TryParse(GemNeeded.Text, out var k);
            TotalGemUsed.Text = (o + k - 12).ToString();

            int.TryParse(TotalPowderUsed.Text, out var p);
            int.TryParse(PowderNeeded.Text, out var l);
            TotalPowderUsed.Text = (p + l - 150).ToString();
        }


        private void AmuletUsed()
        {
            int j = 1;
            int.TryParse(TotalAmuletsUsed.Text, out var i);
            TotalAmuletsUsed.Text = (i + j).ToString();
        }


        private void ScrollUsed()
        {
            int j = 1;
            int.TryParse(TotalScrollsUsed.Text, out var i);
            TotalScrollsUsed.Text = (i + j).ToString();
        }


        // Upgrade system
        // Stuff to be implemented
        // destroying items, reset button
        private async void BtnUpgrade_Click(object sender, EventArgs e)
        {
            // without any safety items
            if (IsEqScroll == false & IsEqAmulet == false)
            {
                var random = new Random();
                var num = random.Next(1, 1000);
                if(num < 1000/(1+ SharedClass.UpgradeLvlValue.UpgradeLevel*1.69))
                {
                    lbUpgradeOutput.BackColor = Color.FromArgb(46, 51, 73);
                    await Task.Delay(50);
                    SharedClass.UpgradeLvlValue.UpgradeLevel++;
                    lbUpgradeOutput.Text = "Upgrade succeed";
                    lbUpgradeOutput.BackColor = Color.Green;
                    UpgradeLvl.Text = "+ " + SharedClass.UpgradeLvlValue.UpgradeLevel.ToString();
                    UpgradeMats();
                    TotalMaterials();
                }
                else
                {
                    lbUpgradeOutput.BackColor = Color.FromArgb(46, 51, 73);
                    await Task.Delay(50);
                    lbUpgradeOutput.Text = "Upgrade failed";
                    lbUpgradeOutput.BackColor = Color.Red;
                }
            }

            // with eq scroll only
            else if (IsEqScroll == true & IsEqAmulet == false)
            {
                var random = new Random();
                var num = random.Next(1, 1000);

                if (num < 1000 / (1 + SharedClass.UpgradeLvlValue.UpgradeLevel * 1.69))
                {
                    lbUpgradeOutput.BackColor = Color.FromArgb(46, 51, 73);
                    await Task.Delay(50);
                    SharedClass.UpgradeLvlValue.UpgradeLevel++;
                    lbUpgradeOutput.Text = "Upgrade succeed";
                    lbUpgradeOutput.BackColor = Color.Green;
                    UpgradeLvl.Text = "+ " + SharedClass.UpgradeLvlValue.UpgradeLevel.ToString();
                    UpgradeMats();
                    TotalMaterials();
                }
                else
                {
                    lbUpgradeOutput.BackColor = Color.FromArgb(46, 51, 73);
                    await Task.Delay(50);
                    lbUpgradeOutput.Text = "Upgrade failed";
                    lbUpgradeOutput.BackColor = Color.Red;
                    ScrollUsed();
                }
            }

            // with amulet only
            else if (IsEqScroll == false & IsEqAmulet == true)
            {
                var random = new Random();
                var num = random.Next(1, 1000);

                if (num < 1000 / (1 + SharedClass.UpgradeLvlValue.UpgradeLevel * 1.69))
                {
                    lbUpgradeOutput.BackColor = Color.FromArgb(46, 51, 73);
                    await Task.Delay(25);
                    SharedClass.UpgradeLvlValue.UpgradeLevel++;
                    lbUpgradeOutput.Text = "Upgrade succeed";
                    lbUpgradeOutput.BackColor = Color.Green;
                    UpgradeLvl.Text = "+ " + SharedClass.UpgradeLvlValue.UpgradeLevel.ToString();
                    UpgradeMats();
                    TotalMaterials();
                }
                else
                {
                    lbUpgradeOutput.BackColor = Color.FromArgb(46, 51, 73);
                    await Task.Delay(25);
                    lbUpgradeOutput.Text = "Upgrade failed";
                    lbUpgradeOutput.BackColor = Color.Red;
                    AmuletUsed();
                }
            }

            //with all the safety items
            else
            {
                var random = new Random();
                var num = random.Next(1, 1000);

                if (num < 1000 / (1 + SharedClass.UpgradeLvlValue.UpgradeLevel * 1.69))
                {
                    lbUpgradeOutput.BackColor = Color.FromArgb(46, 51, 73);
                    await Task.Delay(25);
                    SharedClass.UpgradeLvlValue.UpgradeLevel++;
                    lbUpgradeOutput.Text = "Upgrade succeed";
                    lbUpgradeOutput.BackColor = Color.Green;
                    UpgradeLvl.Text = "+ " + SharedClass.UpgradeLvlValue.UpgradeLevel.ToString();
                    UpgradeMats();
                    TotalMaterials();
                }
                else
                {
                    lbUpgradeOutput.BackColor = Color.FromArgb(46, 51, 73);
                    await Task.Delay(25);
                    lbUpgradeOutput.Text = "Upgrade failed";
                    lbUpgradeOutput.BackColor = Color.Red;
                    AmuletUsed();
                    ScrollUsed();
                }
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            int x = SharedClass.UpgradeLvlValue.UpgradeLevel;
            GoldNeeded.Text = ((1 + x) * 750).ToString();
            GemNeeded.Text = ((1 + x) * 12).ToString();
            PowderNeeded.Text = ((1 + x) * 150).ToString();

            TotalGoldUsed.Text = "0";
            TotalGemUsed.Text = "0";
            TotalPowderUsed.Text = "0";
            TotalScrollsUsed.Text = "0";
            TotalAmuletsUsed.Text = "0";
        }
    }
}


