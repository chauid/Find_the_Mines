using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Find_the_Mines
{
    public partial class Information_game : Form
    {
        public Information_game()
        {
            InitializeComponent();
        }

        private void Information_game_Load(object sender, EventArgs e)
        {

            label1.Text = "version : alpha 0.01 \n\n해당 프로그램은 수업시간중에 할게 \n없어서만든 프로그램으로 \n추후 지속적인 업데이트 예정\n\nMake : 장진욱 고범준 김성헉 \n";
        }

    }
}
