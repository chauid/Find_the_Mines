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
        private int setBoardSize;
        private bool IsSound;
        private Size CurrentResolution;
        public delegate void SendSetting(int size, bool sound, Size resolution); //옵션->메인 이벤트 핸들러 선언
        public event SendSetting OptionReturnSetting; // 옵션->메인 이벤트 선언
        public void SetBoard(int size, bool sound, Size resolution) // 메인폼->옵션폼 값 받아오기
        {
            setBoardSize = size;
            switch(setBoardSize)
            {
                case 12:
                    x12Button.Checked = true;
                    break;
                case 16:
                    x16Button.Checked = true;
                    break;
                case 24:
                    x24Button.Checked = true;
                    break;
                case 32:
                    x32Button.Checked = true;
                    break;
                default:
                    break;
            }
            CurrentResolution = resolution;
            switch(CurrentResolution.Width) // 너비 기준
            {
                case 640:
                    Res640x480.Checked = true;
                    break;
                case 1024:
                    Res1024x768.Checked = true;
                    break;
                case 1152:
                    Res1152x864.Checked = true;
                    break;
                default: //FullScreen
                    ResFull.Checked = true;
                    break;
            }
            IsSound = sound;
            SoundCheckBox.Checked = this.IsSound;
        }
        private void LayerSet() // 화면 내의 객체 위치 초기화
        {
            // 색깔 정의
            Color BackGroundColor = Color.FromArgb(242, 242, 242);
            Color DIffScreenColor = Color.FromArgb(255, 247, 239);
            Difficulty.Location = new Point(ClientSize.Width * 1 / 50, ClientSize.Height * 1 / 50);
            Difficulty.Size = new Size(ClientSize.Width * 48 / 50, ClientSize.Height * 15 / 50);
            x12Button.Location = new Point(Difficulty.Size.Width * 5 / 50, Difficulty.Size.Height * 10 / 50);
            x16Button.Location = new Point(Difficulty.Size.Width * 5 / 50, Difficulty.Size.Height * 20 / 50);
            x24Button.Location = new Point(Difficulty.Size.Width * 5 / 50, Difficulty.Size.Height * 30 / 50);
            x32Button.Location = new Point(Difficulty.Size.Width * 5 / 50, Difficulty.Size.Height * 40 / 50);
            OKButton.Location = new Point(ClientSize.Width * 37 / 50 - OKButton.Width, ClientSize.Height * 49 / 50 - OKButton.Height);
            CancelButton.Location = new Point(OKButton.Location.X+OKButton.Width+ClientSize.Width*1/50, ClientSize.Height * 49 / 50 - OKButton.Height);
            Resolution.Location = new Point(ClientSize.Width * 1 / 50, ClientSize.Height * 17 / 50);
            Resolution.Size = new Size(ClientSize.Width * 48 / 50, ClientSize.Height * 15 / 50);
            ResFull.Location = new Point(Difficulty.Size.Width * 5 / 50, Difficulty.Size.Height * 10 / 50);
            Res1152x864.Location = new Point(Difficulty.Size.Width * 5 / 50, Difficulty.Size.Height * 20 / 50);
            Res1024x768.Location = new Point(Difficulty.Size.Width * 5 / 50, Difficulty.Size.Height * 30 / 50);
            Res640x480.Location = new Point(Difficulty.Size.Width * 5 / 50, Difficulty.Size.Height * 40 / 50);

        }

        /// <summary>
        /// GameOption 이벤트 처리
        /// </summary>
        private void OKButton_Click(object sender, EventArgs e)
        {
            this.OptionReturnSetting(setBoardSize, IsSound, CurrentResolution); // 델리게이트를 이용하여 메인 폼에 이벤트(값) 전달
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
        private void SoundCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            IsSound = SoundCheckBox.Checked;
        }
    }
}
