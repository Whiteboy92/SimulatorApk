namespace SimulatorApk
{
    sealed partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labItemRarity = new System.Windows.Forms.Label();
            this.labItemUpgrade = new System.Windows.Forms.Label();
            this.labItemSelect = new System.Windows.Forms.Label();
            this.btnRarity = new System.Windows.Forms.Button();
            this.btnUpgrade = new System.Windows.Forms.Button();
            this.btnItemSelect = new System.Windows.Forms.Button();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.labItemRarity);
            this.panel1.Controls.Add(this.labItemUpgrade);
            this.panel1.Controls.Add(this.labItemSelect);
            this.panel1.Controls.Add(this.btnRarity);
            this.panel1.Controls.Add(this.btnUpgrade);
            this.panel1.Controls.Add(this.btnItemSelect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 611);
            this.panel1.TabIndex = 0;
            // 
            // labItemRarity
            // 
            this.labItemRarity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(73)))));
            this.labItemRarity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labItemRarity.ForeColor = System.Drawing.Color.Cyan;
            this.labItemRarity.Location = new System.Drawing.Point(3, 401);
            this.labItemRarity.Name = "labItemRarity";
            this.labItemRarity.Size = new System.Drawing.Size(144, 23);
            this.labItemRarity.TabIndex = 5;
            this.labItemRarity.Text = "Rarity";
            this.labItemRarity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labItemUpgrade
            // 
            this.labItemUpgrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(73)))));
            this.labItemUpgrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labItemUpgrade.ForeColor = System.Drawing.Color.Cyan;
            this.labItemUpgrade.Location = new System.Drawing.Point(3, 234);
            this.labItemUpgrade.Name = "labItemUpgrade";
            this.labItemUpgrade.Size = new System.Drawing.Size(144, 23);
            this.labItemUpgrade.TabIndex = 4;
            this.labItemUpgrade.Text = "Upgrade";
            this.labItemUpgrade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labItemSelect
            // 
            this.labItemSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(73)))));
            this.labItemSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labItemSelect.ForeColor = System.Drawing.Color.Cyan;
            this.labItemSelect.Location = new System.Drawing.Point(3, 68);
            this.labItemSelect.Name = "labItemSelect";
            this.labItemSelect.Size = new System.Drawing.Size(144, 23);
            this.labItemSelect.TabIndex = 3;
            this.labItemSelect.Text = "Item Selection";
            this.labItemSelect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRarity
            // 
            this.btnRarity.BackColor = System.Drawing.Color.Transparent;
            this.btnRarity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRarity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRarity.Image = ((System.Drawing.Image)(resources.GetObject("btnRarity.Image")));
            this.btnRarity.Location = new System.Drawing.Point(40, 427);
            this.btnRarity.Name = "btnRarity";
            this.btnRarity.Size = new System.Drawing.Size(63, 63);
            this.btnRarity.TabIndex = 2;
            this.btnRarity.UseVisualStyleBackColor = false;
            this.btnRarity.Click += new System.EventHandler(this.BtnRarity_Click);
            this.btnRarity.Leave += new System.EventHandler(this.BtnRarity_Leave);
            // 
            // btnUpgrade
            // 
            this.btnUpgrade.BackColor = System.Drawing.Color.Transparent;
            this.btnUpgrade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpgrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpgrade.Image = ((System.Drawing.Image)(resources.GetObject("btnUpgrade.Image")));
            this.btnUpgrade.Location = new System.Drawing.Point(40, 260);
            this.btnUpgrade.Name = "btnUpgrade";
            this.btnUpgrade.Size = new System.Drawing.Size(63, 63);
            this.btnUpgrade.TabIndex = 1;
            this.btnUpgrade.UseVisualStyleBackColor = false;
            this.btnUpgrade.Click += new System.EventHandler(this.BtnUpgrade_Click);
            this.btnUpgrade.Leave += new System.EventHandler(this.BtnUpgrade_Leave);
            // 
            // btnItemSelect
            // 
            this.btnItemSelect.BackColor = System.Drawing.Color.Transparent;
            this.btnItemSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnItemSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItemSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnItemSelect.Image")));
            this.btnItemSelect.Location = new System.Drawing.Point(40, 94);
            this.btnItemSelect.Name = "btnItemSelect";
            this.btnItemSelect.Size = new System.Drawing.Size(63, 63);
            this.btnItemSelect.TabIndex = 0;
            this.btnItemSelect.UseVisualStyleBackColor = false;
            this.btnItemSelect.Click += new System.EventHandler(this.BtnItemSelect_Click);
            this.btnItemSelect.Leave += new System.EventHandler(this.BtnItemSelect_Leave);
            // 
            // panelDesktop
            // 
            this.panelDesktop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDesktop.Location = new System.Drawing.Point(150, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1034, 611);
            this.panelDesktop.TabIndex = 1;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MyMain_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelDesktop;

        private System.Windows.Forms.Label labItemUpgrade;
        private System.Windows.Forms.Label labItemRarity;

        private System.Windows.Forms.Label labItemSelect;

        private System.Windows.Forms.Panel panel1;

        #endregion
        private System.Windows.Forms.Button btnRarity;
        private System.Windows.Forms.Button btnItemSelect;
        public System.Windows.Forms.Button btnUpgrade;
    }
}