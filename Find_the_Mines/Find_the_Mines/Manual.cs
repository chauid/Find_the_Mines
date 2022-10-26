using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Find_the_Mines
{
    public partial class Manual : Form
    {
        private void Layerset()
        {
            title.Location = new Point(ClientSize.Width * 1 / 2 - title.Width / 2, ClientSize.Height * 1 / 50);
            Color BackPanelColor = Color.FromArgb(217, 217, 217);
            backpanel.Location = new System.Drawing.Point(ClientSize.Width * 1 / 5, ClientSize.Width * 1 / 10);
            backpanel.Size = new Size(ClientSize.Width * 3 / 5, ClientSize.Height * 4 / 5);
            backpanel.BackColor = BackPanelColor;
            backpanel.SendToBack();
        }
        private void Labelset(params Label[] labels)
        {
            int iteration = labels.Length;
            for (int i = 0; i < iteration; i++)
            {
                labels[i].Location = new System.Drawing.Point(10, i * labels[i].Size.Height);
                labels[i].Size = new Size(backpanel.Width * 45 / 50, labels[i].Size.Height);
            }
        }

        public Manual(int width = 400, int height = 400)
        {
            InitializeComponent();
         
            
            int rules = 10; // 규칙 개수
            Label[] labels = new Label[rules];
            for (int i = 0; i < rules; i++) // 라벨 배열 초기화
            {
                labels[i] = new Label();
                labels[i].Padding = new System.Windows.Forms.Padding(5);
                labels[i].AutoSize = true;
                labels[i].Name = "label" + i;
                labels[i].TabIndex = 0;
                this.backpanel.Controls.Add(labels[i]);
            }
            // 라벨 배열 텍스트
            labels[0].Text = "1. 두 플레이어가 번갈아가며 보드에서 원하는 곳을 클릭해주세요.";
            labels[1].Text = "1-1. 클릭 시 모양 +와 × 중 선택";
            labels[2].Text = "내용";
            labels[3].Text = "추가";
            labels[4].Text = "예정";
            labels[5].Text = "입니";
            labels[6].Text = "다용";
            labels[7].Text = "ㅎㅎ";
            labels[8].Text = "";
            labels[9].Text = "";

            Labelset(labels);
            int Max_fontsize = 0;
            int Max_width_labelinedex = 0;
            for (int i = 0; i < rules; i++) Console.WriteLine("{0},\"{1}\"\n", labels[i].Name, labels[i].Text); //Debug
            for (int i = 0; i < rules; i++) if (Max_fontsize < labels[i].Width) { Max_fontsize = labels[i].Width; Max_width_labelinedex = i; }
            width_change(Max_fontsize, height, labels[Max_width_labelinedex].Width);


            Console.WriteLine("Manual 폼 실행됨."); //Debug
        }

        private void Manual_SizeChanged(object sender, EventArgs e)
        {
            Layerset();
        }

        private void Manual_FormClosed(object sender, FormClosedEventArgs e)
        {
            Console.WriteLine("Manual 폼 종료됨."); //Debug
        }

        public void width_change(int width, int height , int backpanel_width)
        {
            Console.WriteLine(backpanel_width);
            this.ClientSize = new Size(width + backpanel_width-100, height+200); 
        }

    }
}
