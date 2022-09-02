using System.ComponentModel;

namespace SimulatorApk
{
    partial class ItemUpgradeMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemUpgradeMenu));
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUpgrade = new System.Windows.Forms.Button();
            this.cBoxScroll = new System.Windows.Forms.CheckBox();
            this.cBoxAmulet = new System.Windows.Forms.CheckBox();
            this.pbItemUpgrade = new System.Windows.Forms.PictureBox();
            this.Powder = new System.Windows.Forms.Label();
            this.Gem = new System.Windows.Forms.Label();
            this.Gold = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lbTotals = new System.Windows.Forms.Label();
            this.lbGoldUsed = new System.Windows.Forms.Label();
            this.lbPowderUsed = new System.Windows.Forms.Label();
            this.TotalGoldUsed = new System.Windows.Forms.Label();
            this.TotalGemUsed = new System.Windows.Forms.Label();
            this.TotalPowderUsed = new System.Windows.Forms.Label();
            this.lbGemUsed = new System.Windows.Forms.Label();
            this.PowderNeeded = new System.Windows.Forms.Label();
            this.GemNeeded = new System.Windows.Forms.Label();
            this.GoldNeeded = new System.Windows.Forms.Label();
            this.lbUpgradeLvl = new System.Windows.Forms.Label();
            this.UpgradeLvl = new System.Windows.Forms.Label();
            this.lbUpgradeOutput = new System.Windows.Forms.Label();
            this.lbScrollsUsed = new System.Windows.Forms.Label();
            this.TotalScrollsUsed = new System.Windows.Forms.Label();
            this.lbAmuletsUsed = new System.Windows.Forms.Label();
            this.TotalAmuletsUsed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemUpgrade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnReset.Location = new System.Drawing.Point(121, 431);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnUpgrade
            // 
            this.btnUpgrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpgrade.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUpgrade.Location = new System.Drawing.Point(121, 460);
            this.btnUpgrade.Name = "btnUpgrade";
            this.btnUpgrade.Size = new System.Drawing.Size(75, 23);
            this.btnUpgrade.TabIndex = 1;
            this.btnUpgrade.Text = "Upgrade";
            this.btnUpgrade.UseVisualStyleBackColor = true;
            this.btnUpgrade.Click += new System.EventHandler(this.BtnUpgrade_Click);
            // 
            // cBoxScroll
            // 
            this.cBoxScroll.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.cBoxScroll.Location = new System.Drawing.Point(261, 431);
            this.cBoxScroll.Name = "cBoxScroll";
            this.cBoxScroll.Size = new System.Drawing.Size(170, 24);
            this.cBoxScroll.TabIndex = 3;
            this.cBoxScroll.Text = "Use Eq Protection scroll";
            this.cBoxScroll.UseVisualStyleBackColor = true;
            // 
            // cBoxAmulet
            // 
            this.cBoxAmulet.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.cBoxAmulet.Location = new System.Drawing.Point(261, 460);
            this.cBoxAmulet.Name = "cBoxAmulet";
            this.cBoxAmulet.Size = new System.Drawing.Size(170, 24);
            this.cBoxAmulet.TabIndex = 4;
            this.cBoxAmulet.Text = "Use Amulet Of Reinforcement";
            this.cBoxAmulet.UseVisualStyleBackColor = true;
            // 
            // pbItemUpgrade
            // 
            this.pbItemUpgrade.Location = new System.Drawing.Point(169, 155);
            this.pbItemUpgrade.Name = "pbItemUpgrade";
            this.pbItemUpgrade.Size = new System.Drawing.Size(40, 40);
            this.pbItemUpgrade.TabIndex = 5;
            this.pbItemUpgrade.TabStop = false;
            // 
            // Powder
            // 
            this.Powder.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Powder.Location = new System.Drawing.Point(116, 322);
            this.Powder.Name = "Powder";
            this.Powder.Size = new System.Drawing.Size(63, 23);
            this.Powder.TabIndex = 6;
            this.Powder.Text = "Powder";
            // 
            // Gem
            // 
            this.Gem.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Gem.Location = new System.Drawing.Point(198, 322);
            this.Gem.Name = "Gem";
            this.Gem.Size = new System.Drawing.Size(50, 23);
            this.Gem.TabIndex = 7;
            this.Gem.Text = "Gem";
            // 
            // Gold
            // 
            this.Gold.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Gold.Location = new System.Drawing.Point(288, 322);
            this.Gold.Name = "Gold";
            this.Gold.Size = new System.Drawing.Size(52, 23);
            this.Gold.TabIndex = 8;
            this.Gold.Text = "Gold";
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(119, 348);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(201, 348);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 34);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(291, 348);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 34);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // lbTotals
            // 
            this.lbTotals.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbTotals.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbTotals.Location = new System.Drawing.Point(493, 118);
            this.lbTotals.Name = "lbTotals";
            this.lbTotals.Size = new System.Drawing.Size(145, 23);
            this.lbTotals.TabIndex = 12;
            this.lbTotals.Text = "Total materials used";
            // 
            // lbGoldUsed
            // 
            this.lbGoldUsed.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbGoldUsed.Location = new System.Drawing.Point(493, 172);
            this.lbGoldUsed.Name = "lbGoldUsed";
            this.lbGoldUsed.Size = new System.Drawing.Size(100, 23);
            this.lbGoldUsed.TabIndex = 13;
            this.lbGoldUsed.Text = "Gold Used:";
            // 
            // lbPowderUsed
            // 
            this.lbPowderUsed.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbPowderUsed.Location = new System.Drawing.Point(493, 217);
            this.lbPowderUsed.Name = "lbPowderUsed";
            this.lbPowderUsed.Size = new System.Drawing.Size(100, 23);
            this.lbPowderUsed.TabIndex = 15;
            this.lbPowderUsed.Text = "Powder Used:";
            // 
            // TotalGoldUsed
            // 
            this.TotalGoldUsed.Location = new System.Drawing.Point(599, 172);
            this.TotalGoldUsed.Name = "TotalGoldUsed";
            this.TotalGoldUsed.Size = new System.Drawing.Size(100, 23);
            this.TotalGoldUsed.TabIndex = 16;
            // 
            // TotalGemUsed
            // 
            this.TotalGemUsed.Location = new System.Drawing.Point(599, 194);
            this.TotalGemUsed.Name = "TotalGemUsed";
            this.TotalGemUsed.Size = new System.Drawing.Size(100, 23);
            this.TotalGemUsed.TabIndex = 17;
            // 
            // TotalPowderUsed
            // 
            this.TotalPowderUsed.Location = new System.Drawing.Point(599, 217);
            this.TotalPowderUsed.Name = "TotalPowderUsed";
            this.TotalPowderUsed.Size = new System.Drawing.Size(100, 23);
            this.TotalPowderUsed.TabIndex = 18;
            // 
            // lbGemUsed
            // 
            this.lbGemUsed.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbGemUsed.Location = new System.Drawing.Point(493, 195);
            this.lbGemUsed.Name = "lbGemUsed";
            this.lbGemUsed.Size = new System.Drawing.Size(100, 23);
            this.lbGemUsed.TabIndex = 19;
            this.lbGemUsed.Text = "Gem Used:";
            // 
            // PowderNeeded
            // 
            this.PowderNeeded.AutoSize = true;
            this.PowderNeeded.Location = new System.Drawing.Point(118, 385);
            this.PowderNeeded.Name = "PowderNeeded";
            this.PowderNeeded.Size = new System.Drawing.Size(0, 13);
            this.PowderNeeded.TabIndex = 20;
            // 
            // GemNeeded
            // 
            this.GemNeeded.AutoSize = true;
            this.GemNeeded.Location = new System.Drawing.Point(200, 385);
            this.GemNeeded.Name = "GemNeeded";
            this.GemNeeded.Size = new System.Drawing.Size(0, 13);
            this.GemNeeded.TabIndex = 21;
            // 
            // GoldNeeded
            // 
            this.GoldNeeded.AutoSize = true;
            this.GoldNeeded.Location = new System.Drawing.Point(290, 385);
            this.GoldNeeded.Name = "GoldNeeded";
            this.GoldNeeded.Size = new System.Drawing.Size(0, 13);
            this.GoldNeeded.TabIndex = 22;
            // 
            // lbUpgradeLvl
            // 
            this.lbUpgradeLvl.AutoSize = true;
            this.lbUpgradeLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbUpgradeLvl.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbUpgradeLvl.Location = new System.Drawing.Point(132, 213);
            this.lbUpgradeLvl.Name = "lbUpgradeLvl";
            this.lbUpgradeLvl.Size = new System.Drawing.Size(102, 18);
            this.lbUpgradeLvl.TabIndex = 23;
            this.lbUpgradeLvl.Text = "Upgrade Level";
            // 
            // UpgradeLvl
            // 
            this.UpgradeLvl.AutoSize = true;
            this.UpgradeLvl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.UpgradeLvl.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.UpgradeLvl.Location = new System.Drawing.Point(240, 213);
            this.UpgradeLvl.Name = "UpgradeLvl";
            this.UpgradeLvl.Size = new System.Drawing.Size(0, 18);
            this.UpgradeLvl.TabIndex = 24;
            // 
            // lbUpgradeOutput
            // 
            this.lbUpgradeOutput.Location = new System.Drawing.Point(132, 117);
            this.lbUpgradeOutput.Name = "lbUpgradeOutput";
            this.lbUpgradeOutput.Size = new System.Drawing.Size(116, 24);
            this.lbUpgradeOutput.TabIndex = 25;
            this.lbUpgradeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbScrollsUsed
            // 
            this.lbScrollsUsed.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbScrollsUsed.Location = new System.Drawing.Point(493, 240);
            this.lbScrollsUsed.Name = "lbScrollsUsed";
            this.lbScrollsUsed.Size = new System.Drawing.Size(100, 23);
            this.lbScrollsUsed.TabIndex = 26;
            this.lbScrollsUsed.Text = "Scrolls Used:";
            // 
            // TotalScrollsUsed
            // 
            this.TotalScrollsUsed.Location = new System.Drawing.Point(599, 240);
            this.TotalScrollsUsed.Name = "TotalScrollsUsed";
            this.TotalScrollsUsed.Size = new System.Drawing.Size(100, 23);
            this.TotalScrollsUsed.TabIndex = 27;
            // 
            // lbAmuletsUsed
            // 
            this.lbAmuletsUsed.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lbAmuletsUsed.Location = new System.Drawing.Point(493, 263);
            this.lbAmuletsUsed.Name = "lbAmuletsUsed";
            this.lbAmuletsUsed.Size = new System.Drawing.Size(100, 23);
            this.lbAmuletsUsed.TabIndex = 28;
            this.lbAmuletsUsed.Text = "Amulets Used:";
            // 
            // TotalAmuletsUsed
            // 
            this.TotalAmuletsUsed.Location = new System.Drawing.Point(599, 263);
            this.TotalAmuletsUsed.Name = "TotalAmuletsUsed";
            this.TotalAmuletsUsed.Size = new System.Drawing.Size(100, 23);
            this.TotalAmuletsUsed.TabIndex = 29;
            // 
            // ItemUpgradeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1018, 572);
            this.Controls.Add(this.TotalAmuletsUsed);
            this.Controls.Add(this.lbAmuletsUsed);
            this.Controls.Add(this.TotalScrollsUsed);
            this.Controls.Add(this.lbScrollsUsed);
            this.Controls.Add(this.lbUpgradeOutput);
            this.Controls.Add(this.UpgradeLvl);
            this.Controls.Add(this.lbUpgradeLvl);
            this.Controls.Add(this.GoldNeeded);
            this.Controls.Add(this.GemNeeded);
            this.Controls.Add(this.PowderNeeded);
            this.Controls.Add(this.lbGemUsed);
            this.Controls.Add(this.TotalPowderUsed);
            this.Controls.Add(this.TotalGemUsed);
            this.Controls.Add(this.TotalGoldUsed);
            this.Controls.Add(this.lbPowderUsed);
            this.Controls.Add(this.lbGoldUsed);
            this.Controls.Add(this.lbTotals);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Gold);
            this.Controls.Add(this.Gem);
            this.Controls.Add(this.Powder);
            this.Controls.Add(this.pbItemUpgrade);
            this.Controls.Add(this.cBoxAmulet);
            this.Controls.Add(this.cBoxScroll);
            this.Controls.Add(this.btnUpgrade);
            this.Controls.Add(this.btnReset);
            this.Name = "ItemUpgradeMenu";
            this.Text = "ItemUpgradeMenu";
            this.Load += new System.EventHandler(this.ItemUpgradeMenu_Load);
            this.Shown += new System.EventHandler(this.ItemUpgradeMenu_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbItemUpgrade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lbGemUsed;

        private System.Windows.Forms.Label lbPowderUsed;

        private System.Windows.Forms.Label lbGoldUsed;

        private System.Windows.Forms.Label lbTotals;

        private System.Windows.Forms.PictureBox pictureBox4;

        private System.Windows.Forms.PictureBox pictureBox3;

        private System.Windows.Forms.Label Powder;
        private System.Windows.Forms.Label Gem;
        private System.Windows.Forms.Label Gold;
        private System.Windows.Forms.PictureBox pictureBox2;

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUpgrade;
        private System.Windows.Forms.PictureBox pbItemUpgrade;

        #endregion
        private System.Windows.Forms.Label lbUpgradeLvl;
        private System.Windows.Forms.Label UpgradeLvl;
        private System.Windows.Forms.Label lbUpgradeOutput;
        private System.Windows.Forms.Label lbScrollsUsed;
        private System.Windows.Forms.Label lbAmuletsUsed;
        public System.Windows.Forms.CheckBox cBoxScroll;
        public System.Windows.Forms.CheckBox cBoxAmulet;
        private System.Windows.Forms.Label TotalGoldUsed;
        private System.Windows.Forms.Label TotalPowderUsed;
        private System.Windows.Forms.Label TotalGemUsed;
        private System.Windows.Forms.Label TotalScrollsUsed;
        private System.Windows.Forms.Label TotalAmuletsUsed;
        private System.Windows.Forms.Label PowderNeeded;
        private System.Windows.Forms.Label GemNeeded;
        private System.Windows.Forms.Label GoldNeeded;
    }
}