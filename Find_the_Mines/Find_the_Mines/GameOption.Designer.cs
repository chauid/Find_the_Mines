
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
            this.Difficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // Difficulty
            // 
            this.Difficulty.Controls.Add(this.x32Button);
            this.Difficulty.Controls.Add(this.x24Button);
            this.Difficulty.Controls.Add(this.x16Button);
            this.Difficulty.Controls.Add(this.x12Button);
            this.Difficulty.Location = new System.Drawing.Point(23, 25);
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.Size = new System.Drawing.Size(451, 180);
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
            this.OKButton.Location = new System.Drawing.Point(247, 353);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(100, 25);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "확인";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(374, 353);
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
            this.SoundCheckBox.Location = new System.Drawing.Point(62, 226);
            this.SoundCheckBox.Name = "SoundCheckBox";
            this.SoundCheckBox.Size = new System.Drawing.Size(78, 19);
            this.SoundCheckBox.TabIndex = 2;
            this.SoundCheckBox.Text = "소리 켜기";
            this.SoundCheckBox.UseVisualStyleBackColor = true;
            // 
            // GameOption
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.SoundCheckBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.Difficulty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GameOption";
            this.Text = "설정";
            this.Difficulty.ResumeLayout(false);
            this.Difficulty.PerformLayout();
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
    }
}