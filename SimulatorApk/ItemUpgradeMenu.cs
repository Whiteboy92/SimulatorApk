using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulatorApk
{
    public partial class ItemUpgradeMenu : Form
    {
        public ItemUpgradeMenu()
        {
            InitializeComponent();

        }

        private void ItemUpgradeMenu_Load(object sender, System.EventArgs e)
        {
            pbItemUpgrade.Image = SharedClass.ImageToDisplay;
        }

        private void ItemUpgradeMenu_Shown(object sender, System.EventArgs e)
        {
            Image img = GetImage();
        }
        Image GetImage()
        {
            while (SharedClass.ImageToDisplay == null)
            {
            }
            return SharedClass.ImageToDisplay;
        }
    }
}


