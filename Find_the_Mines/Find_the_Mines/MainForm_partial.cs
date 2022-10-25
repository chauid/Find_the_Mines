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
    public partial class MainForm
    {
        private int BoardSize = 12; //기본보드판 크기 : 12 x 12
        private bool IsSound = true; // 사운드 기본값 : 켜기
        private Size Resolution; // 기본 해상도 1024x768
        private void OptionToMainSetting(int size, bool sound, Size resolution) // 옵션값 전달 이벤트 핸들러
        {
            BoardSize = size;
            IsSound = sound;
            Resolution = resolution;
            ClientSize = resolution;
            if(ClientSize.Width == Screen.PrimaryScreen.Bounds.Width) // 전체화면
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else this.WindowState = FormWindowState.Normal;
            Console.WriteLine("현재 보드 크기 : {0}", BoardSize);
            Console.WriteLine("현재 소리 켜기 : {0}", IsSound);
            Console.WriteLine("현재 해상도 : {0}", Resolution);
        }
        private void LayerSet()
        {
            // 색깔 정의
            Color BackGroundColor = Color.FromArgb(242, 242, 242);
            Color ScreenColor = Color.FromArgb(255, 247, 239);
            Color GameScreenColor = Color.FromArgb(231, 227, 236);
            First_Layer.Location = new Point(0, 0);
            First_Layer.Size = ClientSize;
            First_Layer.BackColor = BackGroundColor;
            First_Layer.SendToBack();
            BackScreen.Location = new Point(First_Layer.Width * 2 / 50, First_Layer.Height * 3 / 50);
            BackScreen.Size = new Size(First_Layer.Width / 2, First_Layer.Height * 45 / 50);
            BackScreen.BackColor = ScreenColor;
            GameScreen.Location = new Point(20, 150);
            GameScreen.Size = new Size(BackScreen.Width - 40, BackScreen.Height - 170);
            GameScreen.BackColor = GameScreenColor;
            GameScreen.BringToFront();
            ShowManual.Location = new Point(First_Layer.Width * 45 / 50 - ShowManual.Width, First_Layer.Height * 3 / 50);

            chat_pannel.Size = new Size(First_Layer.Width * 21 / 50, First_Layer.Height * 20 / 50);
            chat_pannel.Location = new Point(First_Layer.Width - First_Layer.Width * 22 / 50, First_Layer.Height - First_Layer.Height * 23 / 50);
            chat_Box.Size = new Size(chat_pannel.Width * 46 / 50, chat_pannel.Height * 37 / 50);
            chat_Box.Location = new Point(chat_pannel.Width * 2 / 50, chat_pannel.Height * 3 / 50);
            chat_Text.Size = new Size(chat_pannel.Width - 150, chat_Text.Height);
            chat_Text.Location = new Point(chat_pannel.Width * 2 / 50, chat_pannel.Height * 42 / 50);
            chat_input_button.Location = new Point(chat_Text.Location.X + chat_Text.Width + 10, chat_Text.Location.Y);
        }


        /// <summary>
        /// Event Handler 이벤트 처리
        /// </summary>
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
            else Man.BringToFront();
        }
        private void OptionButton_Click(object sender, EventArgs e)
        {
            Form Opt = Application.OpenForms["GameOption"];
            if (Opt == null)
            {
                GameOption Option = new GameOption();
                Option.Owner = this;
                Option.StartPosition = FormStartPosition.CenterParent;
                Option.SetBoard(BoardSize, IsSound, this.ClientSize);
                Option.OptionReturnSetting += OptionToMainSetting;
                Option.ShowDialog();
            }
            else Opt.BringToFront();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Control:
                    switch (e.KeyCode)
                    {
                        case Keys.O:
                            Console.WriteLine("key : {0}", e.KeyCode);
                            this.OptionButton.Click += new System.EventHandler(this.OptionButton_Click);
                            break;
                    }
                    break;
            }
        }
        private void ChatSend_Click(object sender, EventArgs e)
        {
            if (chat_Box.Items.Count == 0) for (int i = 0; i < 50; i++) chat_Box.Items.Add("");
            if (chat_Text.Text != "")
            {
                DateTime today = DateTime.Now;
                //소켓통신하게 되면 채팅 구조를 [시간 분 초] "채팅쓴사람 닉네임 : Text " 로 만들거임
                string chat = "[" + today.Hour + ":" + today.Minute + ":" + today.Second + "]" + " " + chat_Text.Text;
                chat_Box.Items.Add(chat);
                chat_Box.SelectedIndex = chat_Box.Items.Count - 1;
                chat_Box.SelectedIndex = -1;
                chat_Text.Text = "";
            }
        }

        private void Chat_Textbox(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) ChatSend_Click(sender, e);
        }

        private void Information(object sender, EventArgs e)
        {
            Information_game info = new Information_game();
            info.Show();
        }
    }
}
