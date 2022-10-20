
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
            this.First_Layer.SuspendLayout();
            this.Screen.SuspendLayout();
            this.SuspendLayout();
            // 
            // First_Layer
            // 
            this.First_Layer.Controls.Add(this.ShowManual);
            this.First_Layer.Controls.Add(this.Screen);
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
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.First_Layer);
            this.Name = "MainForm";
            this.Text = "지뢰찾기";
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.First_Layer.ResumeLayout(false);
            this.Screen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel First_Layer;
        private System.Windows.Forms.Panel Screen;
        private System.Windows.Forms.Panel GameScreen;
        private System.Windows.Forms.Button ShowManual;
    }
}

