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
        private void OptionToMainBoardSize(int size) // 보드판 사이즈 이벤트 핸들러
        {
            BoardSize = size;
            Console.WriteLine("현재 보드 크기 : {0}", BoardSize);
        }
        private void OptionToMainIsSound(bool sound)
        {
            IsSound = sound;
            Console.WriteLine("현재 소리 켜기 : {0}", IsSound);
        }
        private void ButtonArrayInit(params Button[] buttons)
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
            Screen.Location = new Point(First_Layer.Width * 2 / 50, First_Layer.Height * 3 / 50);
            Screen.Size = new Size(First_Layer.Width / 2, First_Layer.Height * 45 / 50);
            Screen.BackColor = ScreenColor;
            GameScreen.Location = new Point(20, 150);
            GameScreen.Size = new Size(Screen.Width - 40, Screen.Height - 170);
            GameScreen.BackColor = GameScreenColor;
            GameScreen.BringToFront();
        }

    }
}
