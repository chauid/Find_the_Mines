using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Find_the_Mines
{
    public partial class GameOption
    {
        private int BoardSize; //기본보드판 크기 : 12 x 12
        private bool OptionCheck = false;
        public delegate void getSize(int size);
        public event EventHandler ReturnSizeInt;

        public void SetBoard(int size = 12)
        {
            BoardSize = size;
            switch(BoardSize)
            {
                case 12:
                    _12Button.Checked = true;
                    break;
                case 16:
                    _16Button.Checked = true;
                    break;
                case 24:
                    _24Button.Checked = true;
                    break;
                case 32:
                    _32Button.Checked = true;
                    break;
                default:
                    break;
            }
        }
        private void LayerSet()
        {
            // 색깔 정의
            Color BackGroundColor = Color.FromArgb(242, 242, 242);
            Color DIffScreenColor = Color.FromArgb(255, 247, 239);
            Difficulty.Location = new Point(ClientSize.Width * 1 / 50, ClientSize.Height * 1 / 50);
            Difficulty.Size = new Size(ClientSize.Width- ClientSize.Width*2/50, ClientSize.Height - ClientSize.Height*24/50);
            _12Button.Location = new Point(Difficulty.Size.Width * 5 / 50, Difficulty.Size.Height * 10 / 50);
            _16Button.Location = new Point(Difficulty.Size.Width * 5 / 50, Difficulty.Size.Height * 20 / 50);
            _24Button.Location = new Point(Difficulty.Size.Width * 5 / 50, Difficulty.Size.Height * 30 / 50);
            _32Button.Location = new Point(Difficulty.Size.Width * 5 / 50, Difficulty.Size.Height * 40 / 50);
            OKButton.Location = new Point(ClientSize.Width * 37 / 50 - OKButton.Width, ClientSize.Height * 49 / 50 - OKButton.Height);
            CancelButton.Location = new Point(OKButton.Location.X+OKButton.Width+ClientSize.Width*1/50, ClientSize.Height * 49 / 50 - OKButton.Height);
        }
    }
}
