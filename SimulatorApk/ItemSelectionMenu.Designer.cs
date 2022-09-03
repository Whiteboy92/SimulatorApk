using System.ComponentModel;

namespace SimulatorApk
{
    partial class ItemSelectionMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemSelectionMenu));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRollValues = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tbItemStats = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(190, 340);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnViewStats_Click2);
            this.button2.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // button3
            // 
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(260, 340);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 40);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.BtnViewStats_Click2);
            this.button3.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // button4
            // 
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(330, 340);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 40);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.BtnViewStats_Click2);
            this.button4.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(400, 340);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(40, 40);
            this.button5.TabIndex = 4;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.BtnViewStats_Click2);
            this.button5.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(120, 340);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtnViewStats_Click2);
            this.button1.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // btnRollValues
            // 
            this.btnRollValues.Enabled = false;
            this.btnRollValues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRollValues.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRollValues.Location = new System.Drawing.Point(120, 404);
            this.btnRollValues.Name = "btnRollValues";
            this.btnRollValues.Size = new System.Drawing.Size(75, 23);
            this.btnRollValues.TabIndex = 5;
            this.btnRollValues.Text = "Roll Values";
            this.btnRollValues.UseVisualStyleBackColor = true;
            this.btnRollValues.Click += new System.EventHandler(this.BtnRollValues_Click);
            this.btnRollValues.MouseLeave += new System.EventHandler(this.Button_MouseLeave);
            // 
            // tbItemStats
            // 
            this.tbItemStats.Location = new System.Drawing.Point(120, 224);
            this.tbItemStats.Name = "tbItemStats";
            this.tbItemStats.ReadOnly = true;
            this.tbItemStats.Size = new System.Drawing.Size(110, 92);
            this.tbItemStats.TabIndex = 6;
            this.tbItemStats.Text = "";
            // 
            // ItemSelectionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1018, 572);
            this.Controls.Add(this.tbItemStats);
            this.Controls.Add(this.btnRollValues);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Name = "ItemSelectionMenu";
            this.Text = "ItemSelectionMenu";
            this.Shown += new System.EventHandler(this.ItemSelectionMenu_Shown);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Button button4;

        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.Button button5;

        #endregion

        private System.Windows.Forms.Button btnRollValues;
        private BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.RichTextBox tbItemStats;
    }
}