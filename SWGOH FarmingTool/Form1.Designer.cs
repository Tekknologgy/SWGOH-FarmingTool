namespace SWGOH_FarmingTool
{
    partial class frmSWGOH_FarmingTool
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabChars = new System.Windows.Forms.TabPage();
            this.grpGear = new System.Windows.Forms.GroupBox();
            this.grpMods = new System.Windows.Forms.GroupBox();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.lstChars = new System.Windows.Forms.ListBox();
            this.tabMods = new System.Windows.Forms.TabPage();
            this.tabGear = new System.Windows.Forms.TabPage();
            this.tabShards = new System.Windows.Forms.TabPage();
            this.tabControlMain.SuspendLayout();
            this.tabChars.SuspendLayout();
            this.grpMods.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabChars);
            this.tabControlMain.Controls.Add(this.tabMods);
            this.tabControlMain.Controls.Add(this.tabGear);
            this.tabControlMain.Controls.Add(this.tabShards);
            this.tabControlMain.Location = new System.Drawing.Point(12, 12);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1010, 522);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabChars
            // 
            this.tabChars.Controls.Add(this.grpGear);
            this.tabChars.Controls.Add(this.grpMods);
            this.tabChars.Controls.Add(this.btnMinus);
            this.tabChars.Controls.Add(this.btnPlus);
            this.tabChars.Controls.Add(this.lstChars);
            this.tabChars.Location = new System.Drawing.Point(4, 22);
            this.tabChars.Name = "tabChars";
            this.tabChars.Padding = new System.Windows.Forms.Padding(3);
            this.tabChars.Size = new System.Drawing.Size(1002, 496);
            this.tabChars.TabIndex = 0;
            this.tabChars.Text = "Chars";
            this.tabChars.UseVisualStyleBackColor = true;
            // 
            // grpGear
            // 
            this.grpGear.Location = new System.Drawing.Point(169, 112);
            this.grpGear.Name = "grpGear";
            this.grpGear.Size = new System.Drawing.Size(826, 100);
            this.grpGear.TabIndex = 4;
            this.grpGear.TabStop = false;
            this.grpGear.Text = "Gear";
            // 
            // grpMods
            // 
            this.grpMods.Controls.Add(this.btnMod);
            this.grpMods.Location = new System.Drawing.Point(170, 6);
            this.grpMods.Name = "grpMods";
            this.grpMods.Size = new System.Drawing.Size(826, 100);
            this.grpMods.TabIndex = 3;
            this.grpMods.TabStop = false;
            this.grpMods.Text = "Mods";
            // 
            // btnMod
            // 
            this.btnMod.BackgroundImage = global::SWGOH_FarmingTool.Properties.Resources.Mod;
            this.btnMod.FlatAppearance.BorderSize = 0;
            this.btnMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMod.Location = new System.Drawing.Point(7, 20);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(60, 60);
            this.btnMod.TabIndex = 0;
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.BtnMod_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(38, 445);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(26, 23);
            this.btnMinus.TabIndex = 2;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(6, 445);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(26, 23);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            // 
            // lstChars
            // 
            this.lstChars.FormattingEnabled = true;
            this.lstChars.Location = new System.Drawing.Point(6, 6);
            this.lstChars.Name = "lstChars";
            this.lstChars.Size = new System.Drawing.Size(157, 433);
            this.lstChars.TabIndex = 0;
            this.lstChars.SelectedIndexChanged += new System.EventHandler(this.LstChars_SelectedIndexChanged);
            // 
            // tabMods
            // 
            this.tabMods.Location = new System.Drawing.Point(4, 22);
            this.tabMods.Name = "tabMods";
            this.tabMods.Padding = new System.Windows.Forms.Padding(3);
            this.tabMods.Size = new System.Drawing.Size(1002, 496);
            this.tabMods.TabIndex = 1;
            this.tabMods.Text = "Mods";
            this.tabMods.UseVisualStyleBackColor = true;
            // 
            // tabGear
            // 
            this.tabGear.Location = new System.Drawing.Point(4, 22);
            this.tabGear.Name = "tabGear";
            this.tabGear.Padding = new System.Windows.Forms.Padding(3);
            this.tabGear.Size = new System.Drawing.Size(1002, 496);
            this.tabGear.TabIndex = 2;
            this.tabGear.Text = "Gear";
            this.tabGear.UseVisualStyleBackColor = true;
            // 
            // tabShards
            // 
            this.tabShards.Location = new System.Drawing.Point(4, 22);
            this.tabShards.Name = "tabShards";
            this.tabShards.Padding = new System.Windows.Forms.Padding(3);
            this.tabShards.Size = new System.Drawing.Size(1002, 496);
            this.tabShards.TabIndex = 3;
            this.tabShards.Text = "Shards";
            this.tabShards.UseVisualStyleBackColor = true;
            // 
            // frmSWGOH_FarmingTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 596);
            this.Controls.Add(this.tabControlMain);
            this.Name = "frmSWGOH_FarmingTool";
            this.Text = "SWGOH FarmingTool";
            this.tabControlMain.ResumeLayout(false);
            this.tabChars.ResumeLayout(false);
            this.grpMods.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabChars;
        private System.Windows.Forms.TabPage tabMods;
        private System.Windows.Forms.TabPage tabGear;
        private System.Windows.Forms.TabPage tabShards;
        private System.Windows.Forms.ListBox lstChars;
        private System.Windows.Forms.GroupBox grpGear;
        private System.Windows.Forms.GroupBox grpMods;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
    }
}

