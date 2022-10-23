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
            LayerSet(); // 레이어 크기 초기화
            SetBoard(setBoardSize, IsSound);
            Console.WriteLine("OptionForm 실행됨");
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.OptionReturnSize(setBoardSize); // 델리게이트를 이용하여 메인 폼에 이벤트(값) 전달
            this.OptionReturnSound(SoundCheckBox.Checked);
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
    }
}
