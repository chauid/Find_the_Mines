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
            LayerSet(); // 레이어 크기 초기화
            SetBoard();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _12Button_CheckedChanged(object sender, EventArgs e)
        {
            BoardSize = 12;
        }

        private void _16Button_CheckedChanged(object sender, EventArgs e)
        {
            BoardSize = 16;
        }

        private void _24Button_CheckedChanged(object sender, EventArgs e)
        {
            BoardSize = 24;
        }

        private void _32Button_CheckedChanged(object sender, EventArgs e)
        {
            BoardSize = 32;
        }
    }
}
