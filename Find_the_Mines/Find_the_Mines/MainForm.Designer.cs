
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
            this.chat_pannel = new System.Windows.Forms.Panel();
            this.chat_input_button = new System.Windows.Forms.Button();
            this.chat_Box = new System.Windows.Forms.ListBox();
            this.chat_Text = new System.Windows.Forms.TextBox();
            this.ShowManual = new System.Windows.Forms.Button();
            this.BackScreen = new System.Windows.Forms.Panel();
            this.GameScreen = new System.Windows.Forms.Panel();
            this.DropMenu = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Game = new System.Windows.Forms.ToolStripMenuItem();
            this.Setting = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionButton = new System.Windows.Forms.ToolStripMenuItem();
            this.Infomation = new System.Windows.Forms.ToolStripMenuItem();
            this.게임정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.First_Layer.SuspendLayout();
            this.chat_pannel.SuspendLayout();
            this.BackScreen.SuspendLayout();
            this.DropMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // First_Layer
            // 
            this.First_Layer.Controls.Add(this.chat_pannel);
            this.First_Layer.Controls.Add(this.ShowManual);
            this.First_Layer.Controls.Add(this.BackScreen);
            this.First_Layer.Controls.Add(this.DropMenu);
            this.First_Layer.Location = new System.Drawing.Point(0, 0);
            this.First_Layer.Name = "First_Layer";
            this.First_Layer.Size = new System.Drawing.Size(996, 717);
            this.First_Layer.TabIndex = 0;
            // 
            // chat_pannel
            // 
            this.chat_pannel.BackColor = System.Drawing.SystemColors.Control;
            this.chat_pannel.Controls.Add(this.chat_input_button);
            this.chat_pannel.Controls.Add(this.chat_Box);
            this.chat_pannel.Controls.Add(this.chat_Text);
            this.chat_pannel.Location = new System.Drawing.Point(577, 272);
            this.chat_pannel.Name = "chat_pannel";
            this.chat_pannel.Size = new System.Drawing.Size(387, 264);
            this.chat_pannel.TabIndex = 8;
            // 
            // chat_input_button
            // 
            this.chat_input_button.Location = new System.Drawing.Point(295, 220);
            this.chat_input_button.Name = "chat_input_button";
            this.chat_input_button.Size = new System.Drawing.Size(75, 23);
            this.chat_input_button.TabIndex = 6;
            this.chat_input_button.Text = "button1";
            this.chat_input_button.UseVisualStyleBackColor = true;
            this.chat_input_button.Click += new System.EventHandler(this.ChatSend_Click);
            // 
            // chat_Box
            // 
            this.chat_Box.FormattingEnabled = true;
            this.chat_Box.ItemHeight = 15;
            this.chat_Box.Location = new System.Drawing.Point(15, 21);
            this.chat_Box.Name = "chat_Box";
            this.chat_Box.Size = new System.Drawing.Size(355, 184);
            this.chat_Box.TabIndex = 5;
            // 
            // chat_Text
            // 
            this.chat_Text.Location = new System.Drawing.Point(15, 221);
            this.chat_Text.Name = "chat_Text";
            this.chat_Text.Size = new System.Drawing.Size(274, 23);
            this.chat_Text.TabIndex = 7;
            this.chat_Text.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Chat_Textbox);
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
            // BackScreen
            // 
            this.BackScreen.Controls.Add(this.GameScreen);
            this.BackScreen.Location = new System.Drawing.Point(51, 36);
            this.BackScreen.Name = "BackScreen";
            this.BackScreen.Size = new System.Drawing.Size(482, 500);
            this.BackScreen.TabIndex = 1;
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
            this.OptionButton});
            this.Setting.Name = "Setting";
            this.Setting.Size = new System.Drawing.Size(43, 20);
            this.Setting.Text = "설정";
            // 
            // OptionButton
            // 
            this.OptionButton.Name = "OptionButton";
            this.OptionButton.Size = new System.Drawing.Size(126, 22);
            this.OptionButton.Text = "게임 설정";
            this.OptionButton.Click += new System.EventHandler(this.OptionButton_Click);
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
            this.게임정보ToolStripMenuItem.Click += new System.EventHandler(this.Information);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.First_Layer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.DropMenu;
            this.Name = "MainForm";
            this.Text = "지뢰찾기";
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.First_Layer.ResumeLayout(false);
            this.First_Layer.PerformLayout();
            this.chat_pannel.ResumeLayout(false);
            this.chat_pannel.PerformLayout();
            this.BackScreen.ResumeLayout(false);
            this.DropMenu.ResumeLayout(false);
            this.DropMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel First_Layer;
        private System.Windows.Forms.Panel BackScreen;
        private System.Windows.Forms.Panel GameScreen;
        private System.Windows.Forms.Button ShowManual;
        private System.Windows.Forms.MenuStrip DropMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem Game;
        private System.Windows.Forms.ToolStripMenuItem Setting;
        private System.Windows.Forms.ToolStripMenuItem Infomation;
        private System.Windows.Forms.ToolStripMenuItem OptionButton;
        private System.Windows.Forms.ToolStripMenuItem 게임정보ToolStripMenuItem;
        private System.Windows.Forms.ListBox chat_Box;
        private System.Windows.Forms.TextBox chat_Text;
        private System.Windows.Forms.Button chat_input_button;
        private System.Windows.Forms.Panel chat_pannel;
    }
}

