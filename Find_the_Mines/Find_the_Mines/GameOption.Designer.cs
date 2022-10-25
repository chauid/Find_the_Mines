
namespace Find_the_Mines
{
    partial class GameOption
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
            this.Difficulty = new System.Windows.Forms.GroupBox();
            this.x32Button = new System.Windows.Forms.RadioButton();
            this.x24Button = new System.Windows.Forms.RadioButton();
            this.x16Button = new System.Windows.Forms.RadioButton();
            this.x12Button = new System.Windows.Forms.RadioButton();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SoundCheckBox = new System.Windows.Forms.CheckBox();
            this.Resolution = new System.Windows.Forms.GroupBox();
            this.Res1152x864 = new System.Windows.Forms.RadioButton();
            this.Res1024x768 = new System.Windows.Forms.RadioButton();
            this.Res640x480 = new System.Windows.Forms.RadioButton();
            this.ResFull = new System.Windows.Forms.RadioButton();
            this.Difficulty.SuspendLayout();
            this.Resolution.SuspendLayout();
            this.SuspendLayout();
            // 
            // Difficulty
            // 
            this.Difficulty.Controls.Add(this.x32Button);
            this.Difficulty.Controls.Add(this.x24Button);
            this.Difficulty.Controls.Add(this.x16Button);
            this.Difficulty.Controls.Add(this.x12Button);
            this.Difficulty.Location = new System.Drawing.Point(12, 12);
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.Size = new System.Drawing.Size(408, 180);
            this.Difficulty.TabIndex = 0;
            this.Difficulty.TabStop = false;
            this.Difficulty.Text = "플레이 세트";
            // 
            // x32Button
            // 
            this.x32Button.AutoSize = true;
            this.x32Button.Location = new System.Drawing.Point(50, 114);
            this.x32Button.Name = "x32Button";
            this.x32Button.Size = new System.Drawing.Size(67, 19);
            this.x32Button.TabIndex = 3;
            this.x32Button.Text = "32 x 32";
            this.x32Button.UseVisualStyleBackColor = true;
            this.x32Button.CheckedChanged += new System.EventHandler(this.x32Button_CheckedChanged);
            // 
            // x24Button
            // 
            this.x24Button.AutoSize = true;
            this.x24Button.Location = new System.Drawing.Point(50, 88);
            this.x24Button.Name = "x24Button";
            this.x24Button.Size = new System.Drawing.Size(67, 19);
            this.x24Button.TabIndex = 2;
            this.x24Button.Text = "24 x 24";
            this.x24Button.UseVisualStyleBackColor = true;
            this.x24Button.CheckedChanged += new System.EventHandler(this.x24Button_CheckedChanged);
            // 
            // x16Button
            // 
            this.x16Button.AutoSize = true;
            this.x16Button.Location = new System.Drawing.Point(50, 62);
            this.x16Button.Name = "x16Button";
            this.x16Button.Size = new System.Drawing.Size(67, 19);
            this.x16Button.TabIndex = 1;
            this.x16Button.Text = "16 x 16";
            this.x16Button.UseVisualStyleBackColor = true;
            this.x16Button.CheckedChanged += new System.EventHandler(this.x16Button_CheckedChanged);
            // 
            // x12Button
            // 
            this.x12Button.AutoSize = true;
            this.x12Button.Location = new System.Drawing.Point(50, 36);
            this.x12Button.Name = "x12Button";
            this.x12Button.Size = new System.Drawing.Size(67, 19);
            this.x12Button.TabIndex = 0;
            this.x12Button.Text = "12 x 12";
            this.x12Button.UseVisualStyleBackColor = true;
            this.x12Button.CheckedChanged += new System.EventHandler(this.x12Button_CheckedChanged);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(207, 524);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(100, 25);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "확인";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(322, 524);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 25);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "취소";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SoundCheckBox
            // 
            this.SoundCheckBox.AutoSize = true;
            this.SoundCheckBox.Checked = true;
            this.SoundCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SoundCheckBox.Location = new System.Drawing.Point(12, 402);
            this.SoundCheckBox.Name = "SoundCheckBox";
            this.SoundCheckBox.Size = new System.Drawing.Size(78, 19);
            this.SoundCheckBox.TabIndex = 2;
            this.SoundCheckBox.Text = "소리 켜기";
            this.SoundCheckBox.UseVisualStyleBackColor = true;
            // 
            // Resolution
            // 
            this.Resolution.Controls.Add(this.Res1152x864);
            this.Resolution.Controls.Add(this.Res1024x768);
            this.Resolution.Controls.Add(this.Res640x480);
            this.Resolution.Controls.Add(this.ResFull);
            this.Resolution.Location = new System.Drawing.Point(12, 211);
            this.Resolution.Name = "Resolution";
            this.Resolution.Size = new System.Drawing.Size(408, 168);
            this.Resolution.TabIndex = 0;
            this.Resolution.TabStop = false;
            this.Resolution.Text = "해상도 설정";
            // 
            // Res1152x864
            // 
            this.Res1152x864.AutoSize = true;
            this.Res1152x864.Location = new System.Drawing.Point(36, 60);
            this.Res1152x864.Name = "Res1152x864";
            this.Res1152x864.Size = new System.Drawing.Size(88, 19);
            this.Res1152x864.TabIndex = 3;
            this.Res1152x864.TabStop = true;
            this.Res1152x864.Text = "1152 x 864";
            this.Res1152x864.UseVisualStyleBackColor = true;
            this.Res1152x864.CheckedChanged += new System.EventHandler(this.Res1152x864_CheckedChanged);
            // 
            // Res1024x768
            // 
            this.Res1024x768.AutoSize = true;
            this.Res1024x768.Location = new System.Drawing.Point(36, 85);
            this.Res1024x768.Name = "Res1024x768";
            this.Res1024x768.Size = new System.Drawing.Size(88, 19);
            this.Res1024x768.TabIndex = 2;
            this.Res1024x768.TabStop = true;
            this.Res1024x768.Text = "1024 x 768";
            this.Res1024x768.UseVisualStyleBackColor = true;
            this.Res1024x768.CheckedChanged += new System.EventHandler(this.Res1024x768_CheckedChanged);
            // 
            // Res640x480
            // 
            this.Res640x480.AutoSize = true;
            this.Res640x480.Location = new System.Drawing.Point(36, 110);
            this.Res640x480.Name = "Res640x480";
            this.Res640x480.Size = new System.Drawing.Size(81, 19);
            this.Res640x480.TabIndex = 1;
            this.Res640x480.TabStop = true;
            this.Res640x480.Text = "640 x 480";
            this.Res640x480.UseVisualStyleBackColor = true;
            this.Res640x480.CheckedChanged += new System.EventHandler(this.Res640x480_CheckedChanged);
            // 
            // ResFull
            // 
            this.ResFull.AutoSize = true;
            this.ResFull.Location = new System.Drawing.Point(36, 35);
            this.ResFull.Name = "ResFull";
            this.ResFull.Size = new System.Drawing.Size(100, 19);
            this.ResFull.TabIndex = 0;
            this.ResFull.TabStop = true;
            this.ResFull.Text = "전체화면(Full)";
            this.ResFull.UseVisualStyleBackColor = true;
            this.ResFull.CheckedChanged += new System.EventHandler(this.ResFull_CheckedChanged);
            // 
            // GameOption
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(434, 561);
            this.Controls.Add(this.Resolution);
            this.Controls.Add(this.SoundCheckBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.Difficulty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GameOption";
            this.Text = "설정";
            this.Difficulty.ResumeLayout(false);
            this.Difficulty.PerformLayout();
            this.Resolution.ResumeLayout(false);
            this.Resolution.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Difficulty;
        private System.Windows.Forms.RadioButton x24Button;
        private System.Windows.Forms.RadioButton x16Button;
        private System.Windows.Forms.RadioButton x12Button;
        private System.Windows.Forms.Button OKButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.RadioButton x32Button;
        private System.Windows.Forms.CheckBox SoundCheckBox;
        private System.Windows.Forms.GroupBox Resolution;
        private System.Windows.Forms.RadioButton Res1024x768;
        private System.Windows.Forms.RadioButton Res640x480;
        private System.Windows.Forms.RadioButton ResFull;
        private System.Windows.Forms.RadioButton Res1152x864;
    }
}