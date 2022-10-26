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
    class ButtonBoxArray : Form
    {
        private int X, Y; // X축, Y축의 배열 개수
        private PictureBox[,] ButtonArray = new PictureBox[1, 1]; //버튼 배열 선언 [1,1]
        public ButtonBoxArray()
        {
            Console.WriteLine("버튼 배열 객체 생성, 버튼 배열 초기값 : {0}", ButtonArray.ToString());
        }
        public void SetButtonArraySize(int Xvalue, int Yvalue) // 버튼 배열 크기 지정
        {
            this.X = Xvalue; this.Y = Yvalue;
            ButtonArray = new PictureBox[X, Y]; // 버튼 배열 크기 정의
        }

        /*버튼 이미지 적용할 코드 작성*/
    }

}
