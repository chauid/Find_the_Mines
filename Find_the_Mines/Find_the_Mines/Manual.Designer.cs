
namespace Find_the_Mines
{
    partial class Manual
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
            this.title = new System.Windows.Forms.Label();
            this.backpanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(90, 29);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(80, 21);
            this.title.TabIndex = 0;
            this.title.Text = "게임 규칙";
            // 
            // backpanel
            // 
            this.backpanel.Location = new System.Drawing.Point(29, 69);
            this.backpanel.Name = "backpanel";
            this.backpanel.Padding = new System.Windows.Forms.Padding(10);
            this.backpanel.Size = new System.Drawing.Size(223, 161);
            this.backpanel.TabIndex = 1;
            // 
            // Manual
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.title);
            this.Controls.Add(this.backpanel);
            this.Name = "Manual";
            this.Text = "게임 설명서";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Manual_FormClosed);
            this.SizeChanged += new System.EventHandler(this.Manual_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel backpanel;
    }
}