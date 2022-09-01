using System.ComponentModel;

namespace SimulatorApk
{
    partial class ItemRarityMenu
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
            this.pbItemRarity = new System.Windows.Forms.PictureBox();
            this.btnChangeRarity = new System.Windows.Forms.Button();
            this.lbRarity = new System.Windows.Forms.Label();
            this.lbRarityDisplay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbItemRarity)).BeginInit();
            this.SuspendLayout();
            // 
            // pbItemRarity
            // 
            this.pbItemRarity.Location = new System.Drawing.Point(443, 37);
            this.pbItemRarity.Name = "pbItemRarity";
            this.pbItemRarity.Size = new System.Drawing.Size(40, 40);
            this.pbItemRarity.TabIndex = 0;
            this.pbItemRarity.TabStop = false;
            // 
            // btnChangeRarity
            // 
            this.btnChangeRarity.Location = new System.Drawing.Point(426, 493);
            this.btnChangeRarity.Name = "btnChangeRarity";
            this.btnChangeRarity.Size = new System.Drawing.Size(75, 23);
            this.btnChangeRarity.TabIndex = 1;
            this.btnChangeRarity.Text = "Gambling";
            this.btnChangeRarity.UseVisualStyleBackColor = true;
            // 
            // lbRarity
            // 
            this.lbRarity.Location = new System.Drawing.Point(423, 91);
            this.lbRarity.Name = "lbRarity";
            this.lbRarity.Size = new System.Drawing.Size(54, 24);
            this.lbRarity.TabIndex = 2;
            this.lbRarity.Text = "Rarity:";
            this.lbRarity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbRarityDisplay
            // 
            this.lbRarityDisplay.AutoSize = true;
            this.lbRarityDisplay.Location = new System.Drawing.Point(477, 97);
            this.lbRarityDisplay.Name = "lbRarityDisplay";
            this.lbRarityDisplay.Size = new System.Drawing.Size(0, 13);
            this.lbRarityDisplay.TabIndex = 3;
            // 
            // ItemRarityMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1018, 572);
            this.Controls.Add(this.lbRarityDisplay);
            this.Controls.Add(this.lbRarity);
            this.Controls.Add(this.btnChangeRarity);
            this.Controls.Add(this.pbItemRarity);
            this.Name = "ItemRarityMenu";
            this.Text = "ItemRarityMenu";
            this.Load += new System.EventHandler(this.ItemRarityMenu_Load);
            this.Shown += new System.EventHandler(this.ItemRarityMenu_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbItemRarity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbItemRarity;
        private System.Windows.Forms.Button btnChangeRarity;
        private System.Windows.Forms.Label lbRarity;
        private System.Windows.Forms.Label lbRarityDisplay;
    }
}