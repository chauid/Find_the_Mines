﻿
namespace Find_the_Mines
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.First_Layer = new System.Windows.Forms.Panel();
            this.ShowManual = new System.Windows.Forms.Button();
            this.Screen = new System.Windows.Forms.Panel();
            this.GameScreen = new System.Windows.Forms.Panel();
            this.DropMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Game = new System.Windows.Forms.ToolStripMenuItem();
            this.Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.Difficulty = new System.Windows.Forms.ToolStripMenuItem();
            this.Infomation = new System.Windows.Forms.ToolStripMenuItem();
            this.게임정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.First_Layer.SuspendLayout();
            this.Screen.SuspendLayout();
            this.DropMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // First_Layer
            // 
            this.First_Layer.Controls.Add(this.label1);
            this.First_Layer.Controls.Add(this.ShowManual);
            this.First_Layer.Controls.Add(this.Screen);
            this.First_Layer.Controls.Add(this.DropMenu);
            this.First_Layer.Location = new System.Drawing.Point(0, 0);
            this.First_Layer.Name = "First_Layer";
            this.First_Layer.Size = new System.Drawing.Size(996, 717);
            this.First_Layer.TabIndex = 0;
            // 
            // ShowManual
            // 
            this.ShowManual.Location = new System.Drawing.Point(742, 74);
            this.ShowManual.Name = "ShowManual";
            this.ShowManual.Size = new System.Drawing.Size(162, 56);
            this.ShowManual.TabIndex = 2;
            this.ShowManual.Text = "게임설명";
            this.ShowManual.UseVisualStyleBackColor = true;
            this.ShowManual.Click += new System.EventHandler(this.ShowManual_Click);
            // 
            // Screen
            // 
            this.Screen.Controls.Add(this.GameScreen);
            this.Screen.Location = new System.Drawing.Point(51, 36);
            this.Screen.Name = "Screen";
            this.Screen.Size = new System.Drawing.Size(482, 500);
            this.Screen.TabIndex = 1;
            // 
            // GameScreen
            // 
            this.GameScreen.Location = new System.Drawing.Point(28, 85);
            this.GameScreen.Name = "GameScreen";
            this.GameScreen.Size = new System.Drawing.Size(430, 394);
            this.GameScreen.TabIndex = 0;
            // 
            // DropMenu
            // 
            this.DropMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.Game,
            this.Setting,
            this.Infomation});
            this.DropMenu.Location = new System.Drawing.Point(0, 0);
            this.DropMenu.Name = "DropMenu";
            this.DropMenu.Size = new System.Drawing.Size(996, 24);
            this.DropMenu.TabIndex = 3;
            this.DropMenu.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(12, 20);
            // 
            // Game
            // 
            this.Game.Name = "Game";
            this.Game.Size = new System.Drawing.Size(43, 20);
            this.Game.Text = "게임";
            // 
            // Setting
            // 
            this.Setting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Difficulty});
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(43, 20);
            this.Setting.Text = "설정";
            // 
            // Difficulty
            // 
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.Size = new System.Drawing.Size(126, 22);
            this.Difficulty.Text = "게임 설정";
            this.Difficulty.Click += new System.EventHandler(this.Difficulty_Click);
            // 
            // Infomation
            // 
            this.Infomation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.게임정보ToolStripMenuItem});
            this.Infomation.Name = "Infomation";
            this.Infomation.Size = new System.Drawing.Size(43, 20);
            this.Infomation.Text = "정보";
            // 
            // 게임정보ToolStripMenuItem
            // 
            this.게임정보ToolStripMenuItem.Name = "게임정보ToolStripMenuItem";
            this.게임정보ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.게임정보ToolStripMenuItem.Text = "게임 정보";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(690, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.First_Layer);
            this.MainMenuStrip = this.DropMenu;
            this.Name = "MainForm";
            this.Text = "지뢰찾기";
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.First_Layer.ResumeLayout(false);
            this.First_Layer.PerformLayout();
            this.Screen.ResumeLayout(false);
            this.DropMenu.ResumeLayout(false);
            this.DropMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel First_Layer;
        private System.Windows.Forms.Panel Screen;
        private System.Windows.Forms.Panel GameScreen;
        private System.Windows.Forms.Button ShowManual;
        private System.Windows.Forms.MenuStrip DropMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Game;
        private System.Windows.Forms.ToolStripMenuItem Setting;
        private System.Windows.Forms.ToolStripMenuItem Infomation;
        private System.Windows.Forms.ToolStripMenuItem Difficulty;
        private System.Windows.Forms.ToolStripMenuItem 게임정보ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}

