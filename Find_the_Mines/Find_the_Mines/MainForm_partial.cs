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
    public partial class MainForm
    {
        private int BoardSize = 12; //기본보드판 크기 : 12 x 12
        private bool IsSound = true; // 사운드 기본값 : 켜기
        private Size Resolution; // 기본 해상도 1024x768
        private void OptionToMainSetting(int size, bool sound, Size resolution) // 옵션값 전달 이벤트 핸들러
        {
            BoardSize = size;
            IsSound = sound;
            Resolution = resolution;
            ClientSize = resolution;
            if(ClientSize.Width == Screen.PrimaryScreen.Bounds.Width) // 전체화면
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else this.WindowState = FormWindowState.Normal;
            Console.WriteLine("현재 보드 크기 : {0}", BoardSize);
            Console.WriteLine("현재 소리 켜기 : {0}", IsSound);
            Console.WriteLine("현재 해상도 : {0}", Resolution);
        }
        private void ButtonArrayInit(PictureBox[] buttonArray)
        {
            Console.WriteLine("");
        }
        private void LayerSet()
        {
            // 색깔 정의
            Color BackGroundColor = Color.FromArgb(242, 242, 242);
            Color ScreenColor = Color.FromArgb(255, 247, 239);
            Color GameScreenColor = Color.FromArgb(231, 227, 236);
            First_Layer.Location = new Point(0, 0);
            First_Layer.Size = ClientSize;
            First_Layer.BackColor = BackGroundColor;
            First_Layer.SendToBack();
            BackScreen.Location = new Point(First_Layer.Width * 2 / 50, First_Layer.Height * 3 / 50);
            BackScreen.Size = new Size(First_Layer.Width / 2, First_Layer.Height * 45 / 50);
            BackScreen.BackColor = ScreenColor;
            GameScreen.Location = new Point(20, 150);
            GameScreen.Size = new Size(BackScreen.Width - 40, BackScreen.Height - 170);
            GameScreen.BackColor = GameScreenColor;
            GameScreen.BringToFront();
            ShowManual.Location = new Point(First_Layer.Width * 45 / 50 - ShowManual.Width, First_Layer.Height * 3 / 50);
        }

    }
}
