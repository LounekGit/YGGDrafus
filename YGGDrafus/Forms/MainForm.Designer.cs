﻿namespace YGGDrafus
{
    partial class MainForm
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
            if (disposing)
            {
                if (components != null)
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameListToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.upToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.downToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encyclopediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mainMenuStrip.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.gameListToolStripComboBox,
            this.upToolStripMenuItem,
            this.downToolStripMenuItem,
            this.optionToolStripMenuItem,
            this.encyclopediaToolStripMenuItem,
            this.packetToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(931, 29);
            this.mainMenuStrip.TabIndex = 1;
            this.mainMenuStrip.Text = "Menu principal";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(72, 25);
            this.newToolStripMenuItem.Text = "Nouveau";
            this.newToolStripMenuItem.ToolTipText = "Lancer une nouvelle instance du jeu";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // gameListToolStripComboBox
            // 
            this.gameListToolStripComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gameListToolStripComboBox.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameListToolStripComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.gameListToolStripComboBox.Name = "gameListToolStripComboBox";
            this.gameListToolStripComboBox.Size = new System.Drawing.Size(121, 25);
            this.gameListToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.GameListToolStripComboBox_SelectedIndexChanged);
            // 
            // upToolStripMenuItem
            // 
            this.upToolStripMenuItem.Enabled = false;
            this.upToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.upToolStripMenuItem.Name = "upToolStripMenuItem";
            this.upToolStripMenuItem.Size = new System.Drawing.Size(26, 25);
            this.upToolStripMenuItem.Text = "￪";
            this.upToolStripMenuItem.ToolTipText = "Up";
            this.upToolStripMenuItem.Click += new System.EventHandler(this.UpToolStripMenuItem_Click);
            // 
            // downToolStripMenuItem
            // 
            this.downToolStripMenuItem.Enabled = false;
            this.downToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.downToolStripMenuItem.Name = "downToolStripMenuItem";
            this.downToolStripMenuItem.Size = new System.Drawing.Size(26, 25);
            this.downToolStripMenuItem.Text = "￬";
            this.downToolStripMenuItem.ToolTipText = "Down";
            this.downToolStripMenuItem.Click += new System.EventHandler(this.DownToolStripMenuItem_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.optionToolStripMenuItem.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(60, 25);
            this.optionToolStripMenuItem.Text = "Option";
            this.optionToolStripMenuItem.Click += new System.EventHandler(this.OptionToolStripMenuItem_Click);
            // 
            // encyclopediaToolStripMenuItem
            // 
            this.encyclopediaToolStripMenuItem.Name = "encyclopediaToolStripMenuItem";
            this.encyclopediaToolStripMenuItem.Size = new System.Drawing.Size(96, 25);
            this.encyclopediaToolStripMenuItem.Text = "Encyclopédie";
            this.encyclopediaToolStripMenuItem.Click += new System.EventHandler(this.EncyclopediaToolStripMenuItem_Click);
            // 
            // packetToolStripMenuItem
            // 
            this.packetToolStripMenuItem.Name = "packetToolStripMenuItem";
            this.packetToolStripMenuItem.Size = new System.Drawing.Size(60, 25);
            this.packetToolStripMenuItem.Text = "Paquet";
            this.packetToolStripMenuItem.Click += new System.EventHandler(this.PaquetToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 690);
            this.Controls.Add(this.mainMenuStrip);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.Text = "YGGDrafus";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox gameListToolStripComboBox;
        private System.Windows.Forms.ToolStripMenuItem upToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem packetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encyclopediaToolStripMenuItem;

        public System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem { get => newToolStripMenuItem; }
        public System.Windows.Forms.ToolStripComboBox GameListToolStripComboBox { get => gameListToolStripComboBox; }
        public System.Windows.Forms.ToolStripMenuItem OptionToolStripMenuItem { get => optionToolStripMenuItem; }
        public System.Windows.Forms.ToolStripMenuItem PacketToolStripMenuItem { get => packetToolStripMenuItem; }
        public System.Windows.Forms.ToolStripMenuItem EncyclopediaToolStripMenuItem { get => encyclopediaToolStripMenuItem; }
    }
}