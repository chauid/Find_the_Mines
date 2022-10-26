using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Find_the_Mines
{
    public partial class GameOption : Form
    {
        public GameOption()
        {
            InitializeComponent();
            CenterToParent();
            ClientSize = new Size(450, 600); // 옵션 폼 사이즈
            LayerSet(); // 레이어 크기 초기화
            SetBoard(setBoardSize, IsSound, CurrentResolution);
            Console.WriteLine("OptionForm 실행됨");
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.OptionReturnSetting(setBoardSize, IsSound, CurrentResolution); // 델리게이트를 이용하여 메인 폼에 이벤트(값) 전달
/*            DialogResult = DialogResult.OK;
            MainForm Mainform = (MainForm)Owner;
            Mainform.BoardSize = setBoardSize;*/ // 메인 폼에 직접 접근하여 인수 전달 (부모 클래스 변수는 public이어야 함)
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void x12Button_CheckedChanged(object sender, EventArgs e)
        {
            setBoardSize = 12;
        }

        private void x16Button_CheckedChanged(object sender, EventArgs e)
        {
            setBoardSize = 16;
        }

        private void x24Button_CheckedChanged(object sender, EventArgs e)
        {
            setBoardSize = 24;
        }

        private void x32Button_CheckedChanged(object sender, EventArgs e)
        {
            setBoardSize = 32;
        }

        private void ResFull_CheckedChanged(object sender, EventArgs e)
        {
            CurrentResolution = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
        }

        private void Res1152x864_CheckedChanged(object sender, EventArgs e)
        {
            CurrentResolution = new Size(1152, 864);
        }

        private void Res1024x768_CheckedChanged(object sender, EventArgs e)
        {
            CurrentResolution = new Size(1024, 768);
        }

        private void Res640x480_CheckedChanged(object sender, EventArgs e)
        {
            CurrentResolution = new Size(640, 480);
        }

    }
}
