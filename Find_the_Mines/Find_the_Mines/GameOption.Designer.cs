
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
            this._32Button = new System.Windows.Forms.RadioButton();
            this._24Button = new System.Windows.Forms.RadioButton();
            this._16Button = new System.Windows.Forms.RadioButton();
            this._12Button = new System.Windows.Forms.RadioButton();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.Difficulty.SuspendLayout();
            this.SuspendLayout();
            // 
            // Difficulty
            // 
            this.Difficulty.Controls.Add(this._32Button);
            this.Difficulty.Controls.Add(this._24Button);
            this.Difficulty.Controls.Add(this._16Button);
            this.Difficulty.Controls.Add(this._12Button);
            this.Difficulty.Location = new System.Drawing.Point(23, 25);
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.Size = new System.Drawing.Size(451, 180);
            this.Difficulty.TabIndex = 0;
            this.Difficulty.TabStop = false;
            this.Difficulty.Text = "플레이 세트";
            // 
            // _32Button
            // 
            this._32Button.AutoSize = true;
            this._32Button.Location = new System.Drawing.Point(50, 114);
            this._32Button.Name = "_32Button";
            this._32Button.Size = new System.Drawing.Size(67, 19);
            this._32Button.TabIndex = 3;
            this._32Button.Text = "32 x 32";
            this._32Button.UseVisualStyleBackColor = true;
            this._32Button.CheckedChanged += new System.EventHandler(this._32Button_CheckedChanged);
            // 
            // _24Button
            // 
            this._24Button.AutoSize = true;
            this._24Button.Location = new System.Drawing.Point(50, 88);
            this._24Button.Name = "_24Button";
            this._24Button.Size = new System.Drawing.Size(67, 19);
            this._24Button.TabIndex = 2;
            this._24Button.Text = "24 x 24";
            this._24Button.UseVisualStyleBackColor = true;
            this._24Button.CheckedChanged += new System.EventHandler(this._24Button_CheckedChanged);
            // 
            // _16Button
            // 
            this._16Button.AutoSize = true;
            this._16Button.Location = new System.Drawing.Point(50, 62);
            this._16Button.Name = "_16Button";
            this._16Button.Size = new System.Drawing.Size(67, 19);
            this._16Button.TabIndex = 1;
            this._16Button.Text = "16 x 16";
            this._16Button.UseVisualStyleBackColor = true;
            this._16Button.CheckedChanged += new System.EventHandler(this._16Button_CheckedChanged);
            // 
            // _12Button
            // 
            this._12Button.AutoSize = true;
            this._12Button.Location = new System.Drawing.Point(50, 36);
            this._12Button.Name = "_12Button";
            this._12Button.Size = new System.Drawing.Size(67, 19);
            this._12Button.TabIndex = 0;
            this._12Button.Text = "12 x 12";
            this._12Button.UseVisualStyleBackColor = true;
            this._12Button.CheckedChanged += new System.EventHandler(this._12Button_CheckedChanged);
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
            // GameOption
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.Difficulty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GameOption";
            this.Text = "설정";
            this.Difficulty.ResumeLayout(false);
            this.Difficulty.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Difficulty;
        private System.Windows.Forms.RadioButton _24Button;
        private System.Windows.Forms.RadioButton _16Button;
        private System.Windows.Forms.RadioButton _12Button;
        private System.Windows.Forms.Button OKButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.RadioButton _32Button;
    }
}