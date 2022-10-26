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
            Console.WriteLine("OptionForm 실행됨");
        }
    }
}
