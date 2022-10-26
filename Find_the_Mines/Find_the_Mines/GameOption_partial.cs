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
        public delegate void SendSetting(int size, bool sound, Size resolution);
        public event SendSetting OptionReturnSetting;

        public void SetBoard(int size, bool sound, Size resolution)
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
            SoundCheckBox.Checked = IsSound;
        }
        private void LayerSet()
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
    }
}
