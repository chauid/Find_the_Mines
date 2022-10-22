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
    public partial class MainForm : Form
    {
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

        private void Difficulty_Click(object sender, EventArgs e)
        {
            GameOption Option = new GameOption();
            Option.Show();
            //Option.ReturnSizeInt += new GameOption.getSize(getBoardSize);
        }
    }
}
