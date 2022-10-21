using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Find_the_Mines
{
    ///
    public partial class MainForm : Form
    {
        private void LayerSet()
        {
            // 색깔 정의
            Color BackGroundColor = Color.FromArgb(242, 242, 242);
            Color ScreenColor = Color.FromArgb(255, 247, 239);
            Color GameScreenColor = Color.FromArgb(231, 227, 236);
            First_Layer.Location = new System.Drawing.Point(0, 0);
            First_Layer.Size = ClientSize;
            First_Layer.BackColor = BackGroundColor;
            First_Layer.SendToBack();
            Screen.Location = new System.Drawing.Point(First_Layer.Width / 50, First_Layer.Height / 50);
            Screen.Size = new Size(First_Layer.Width / 2, First_Layer.Height * 45 / 50);
            Screen.BackColor = ScreenColor;
            GameScreen.Location = new System.Drawing.Point(20, 150);
            GameScreen.Size = new Size(Screen.Width - 40, Screen.Height - 170);
            GameScreen.BackColor = GameScreenColor;
            GameScreen.BringToFront();
            int i = 1;
        }
        public MainForm()
        {
            InitializeComponent();
            this.ClientSize = new Size(1024, 768); // 초기 창 크기 설정
            LayerSet(); // 초기 패널 설정
            Console.WriteLine("Main 폼 실행됨."); //Debug
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            LayerSet();
        }

        private void ShowManual_Click(object sender, EventArgs e)
        {
            Form Man = Application.OpenForms["Manual"];
            if (Man == null)
            {
                Manual manual = new Manual(400, 400);
                manual.Show();
            }
            else Man.Close();
        }
    }
}
