﻿
namespace FiveM {
    partial class Menu {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.helpBtn = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.topMost = new MaterialSkin.Controls.MaterialCheckbox();
            this.mutateBtn = new MaterialSkin.Controls.MaterialButton();
            this.On = new System.Windows.Forms.Timer(this.components);
            this.statusLabel = new System.Windows.Forms.RichTextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.currModel = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // helpBtn
            // 
            this.helpBtn.AutoSize = false;
            this.helpBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.helpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpBtn.Depth = 0;
            this.helpBtn.DrawShadows = true;
            this.helpBtn.HighEmphasis = true;
            this.helpBtn.Icon = null;
            this.helpBtn.Location = new System.Drawing.Point(322, 73);
            this.helpBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.helpBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(91, 25);
            this.helpBtn.TabIndex = 2;
            this.helpBtn.Text = "?";
            this.helpBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.helpBtn.UseAccentColor = false;
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FiveM.Properties.Resources.Loading;
            this.pictureBox1.Location = new System.Drawing.Point(20, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel1.Location = new System.Drawing.Point(9, 145);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(43, 17);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Log =>";
            // 
            // topMost
            // 
            this.topMost.AutoSize = true;
            this.topMost.Depth = 0;
            this.topMost.Location = new System.Drawing.Point(314, 98);
            this.topMost.Margin = new System.Windows.Forms.Padding(0);
            this.topMost.MouseLocation = new System.Drawing.Point(-1, -1);
            this.topMost.MouseState = MaterialSkin.MouseState.HOVER;
            this.topMost.Name = "topMost";
            this.topMost.Ripple = true;
            this.topMost.Size = new System.Drawing.Size(99, 37);
            this.topMost.TabIndex = 4;
            this.topMost.Text = "TopMost";
            this.topMost.UseVisualStyleBackColor = true;
            this.topMost.CheckedChanged += new System.EventHandler(this.topMost_CheckedChanged);
            // 
            // mutateBtn
            // 
            this.mutateBtn.AutoSize = false;
            this.mutateBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.mutateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mutateBtn.Depth = 0;
            this.mutateBtn.DialogResult = System.Windows.Forms.DialogResult.No;
            this.mutateBtn.DrawShadows = true;
            this.mutateBtn.Enabled = false;
            this.mutateBtn.HighEmphasis = true;
            this.mutateBtn.Icon = null;
            this.mutateBtn.Location = new System.Drawing.Point(122, 73);
            this.mutateBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.mutateBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.mutateBtn.Name = "mutateBtn";
            this.mutateBtn.Size = new System.Drawing.Size(179, 84);
            this.mutateBtn.TabIndex = 5;
            this.mutateBtn.Text = "CRASH (INSERT)";
            this.mutateBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.mutateBtn.UseAccentColor = false;
            this.mutateBtn.UseVisualStyleBackColor = true;
            this.mutateBtn.Click += new System.EventHandler(this.mutateBtn_Click);
            // 
            // On
            // 
            this.On.Enabled = true;
            this.On.Interval = 50;
            this.On.Tick += new System.EventHandler(this.On_Tick);
            // 
            // statusLabel
            // 
            this.statusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusLabel.Enabled = false;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(10, 165);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.statusLabel.Size = new System.Drawing.Size(403, 77);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.TabStop = false;
            this.statusLabel.Text = "";
            this.statusLabel.WordWrap = false;
            this.statusLabel.TextChanged += new System.EventHandler(this.statusLabel_TextChanged);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(322, 134);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(91, 25);
            this.materialButton1.TabIndex = 7;
            this.materialButton1.Text = "CLEAR LOG";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.materialLabel2.Location = new System.Drawing.Point(12, 73);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(96, 17);
            this.materialLabel2.TabIndex = 8;
            this.materialLabel2.Text = "Current Model:";
            // 
            // currModel
            // 
            this.currModel.Depth = 0;
            this.currModel.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.currModel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle2;
            this.currModel.Location = new System.Drawing.Point(11, 90);
            this.currModel.MouseState = MaterialSkin.MouseState.HOVER;
            this.currModel.Name = "currModel";
            this.currModel.Size = new System.Drawing.Size(96, 17);
            this.currModel.TabIndex = 9;
            this.currModel.Text = "None";
            this.currModel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 251);
            this.Controls.Add(this.currModel);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.mutateBtn);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.topMost);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.Opacity = 0.9D;
            this.Sizable = false;
            this.Text = "Conrado\'s FiveM Crasher";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialButton helpBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCheckbox topMost;
        private MaterialSkin.Controls.MaterialButton mutateBtn;
        private System.Windows.Forms.Timer On;
        private System.Windows.Forms.RichTextBox statusLabel;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel currModel;
    }
}

