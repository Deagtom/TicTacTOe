namespace Игра
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        public int turnCount = 0;
        public string turn = "x";
        public string[] win = new string[9];

        public void EndGame()
        {
            if (win[0] == win[1] && win[1] == win[2])
            {
                if (win[0] == "x")
                {
                    RedWin();
                }
                else if (win[0] == "o")
                {
                    BlueWin();
                }
            }
            if (win[3] == win[4] && win[4] == win[5])
            {
                if (win[3] == "x")
                {
                    RedWin();
                }
                else if (win[3] == "o")
                {
                    BlueWin();
                }
            }
            if (win[6] == win[7] && win[7] == win[8])
            {
                if (win[6] == "x")
                {
                    RedWin();
                }
                else if (win[6] == "o")
                {
                    BlueWin();
                }
            }
            if (win[0] == win[3] && win[3] == win[6])
            {
                if (win[0] == "x")
                {
                    RedWin();
                }
                else if (win[0] == "o")
                {
                    BlueWin();
                }
            }
            if (win[1] == win[4] && win[4] == win[7])
            {
                if (win[1] == "x")
                {
                    RedWin();
                }
                else if (win[1] == "o")
                {
                    BlueWin();
                }
            }
            if (win[2] == win[5] && win[5] == win[8])
            {
                if (win[2] == "x")
                {
                    RedWin();
                }
                else if (win[2] == "o")
                {
                    BlueWin();
                }
            }
            if (win[0] == win[4] && win[4] == win[8])
            {
                if (win[0] == "x")
                {
                    RedWin();
                }
                else if (win[0] == "o")
                {
                    BlueWin();
                }
            }
            if (win[2] == win[4] && win[4] == win[6])
            {
                if (win[2] == "x")
                {
                    RedWin();
                }
                else if (win[2] == "o")
                {
                    BlueWin();
                }
            }
            else
            {
                Draw();
            }
        }

        public void Draw()
        {
            if (turnCount == 8)
            {
                EndGame endGame = new();
                endGame.WinnerColor.Text = "Ничья";
                endGame.WinnerLabel.Hide();
                endGame.Show();
                this.Hide();
            }
        }

        public void RedWin()
        {
            EndGame endGame = new();
            endGame.WinnerColor.Text = "Красный";
            endGame.WinnerColor.Left = (this.ClientSize.Width - endGame.WinnerColor.Width) / 2;
            endGame.WinnerColor.Top = (this.ClientSize.Height - endGame.WinnerColor.Height) / 3;
            endGame.WinnerColor.ForeColor = Color.Red;
            endGame.Show();
            this.Hide();
        }

        public void BlueWin()
        {
            EndGame endGame = new();
            endGame.WinnerColor.Text = "Синий";
            endGame.WinnerColor.Left = (this.ClientSize.Width - endGame.WinnerColor.Width) / 2;
            endGame.WinnerColor.Top = (this.ClientSize.Height - endGame.WinnerColor.Height) / 3;
            endGame.WinnerColor.ForeColor = Color.Blue;
            endGame.Show();
            this.Hide();
        }

        public void ClickTurn(PictureBox pictureBox)
        {
            if (turn == "x" && pictureBox.Image == null)
            {
                pictureBox.Image = Properties.Resources.Крестик;
                WhoTurnPicture.Image = Properties.Resources.Круг;
                EndGame();
                turn = "o";
                turnCount += 1;
            }
            else if (turn == "o" && pictureBox.Image == null)
            {
                pictureBox.Image = Properties.Resources.Круг;
                WhoTurnPicture.Image = Properties.Resources.Крестик;
                EndGame();
                turn = "x";
                turnCount += 1;
            }
        }

        private void CloseGame()
        {
            Menu Menu = new();
            Menu.Show();
            this.Hide();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            CloseGame();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
            CloseButton.BackColor = Color.Red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Black;
            CloseButton.BackColor = Color.Transparent;
        }

        private void TopLeft_Click(object sender, EventArgs e)
        {
            if (turn == "x")
            {
                win[0] = "x";
            }
            else if (turn == "o")
            {
                win[0] = "o";
            }
            ClickTurn(TopLeftBox);
        }

        private void Top_Click(object sender, EventArgs e)
        {
            if (turn == "x")
            {
                win[1] = "x";
            }
            else if (turn == "o")
            {
                win[1] = "o";
            }
            ClickTurn(TopBox);
        }

        private void TopRight_Click(object sender, EventArgs e)
        {
            if (turn == "x")
            {
                win[2] = "x";
            }
            else if (turn == "o")
            {
                win[2] = "o";
            }
            ClickTurn(TopRightBox);
        }

        private void Left_Click(object sender, EventArgs e)
        {
            if (turn == "x")
            {
                win[3] = "x";
            }
            else if (turn == "o")
            {
                win[3] = "o";
            }
            ClickTurn(LeftBox);
        }

        private void Middle_Click(object sender, EventArgs e)
        {
            if (turn == "x")
            {
                win[4] = "x";
            }
            else if (turn == "o")
            {
                win[4] = "o";
            }
            ClickTurn(MiddleBox);
        }

        private void Right_Click(object sender, EventArgs e)
        {
            if (turn == "x")
            {
                win[5] = "x";
            }
            else if (turn == "o")
            {
                win[5] = "o";
            }
            ClickTurn(RightBox);
        }

        private void BottomLeft_Click(object sender, EventArgs e)
        {
            if (turn == "x")
            {
                win[6] = "x";
            }
            else if (turn == "o")
            {
                win[6] = "o";
            }
            ClickTurn(BottomLeftBox);
        }

        private void Bottom_Click(object sender, EventArgs e)
        {
            if (turn == "x")
            {
                win[7] = "x";
            }
            else if (turn == "o")
            {
                win[7] = "o";
            }
            ClickTurn(BottomBox);
        }

        private void BottomRight_Click(object sender, EventArgs e)
        {
            if (turn == "x")
            {
                win[8] = "x";
            }
            else if (turn == "o")
            {
                win[8] = "o";
            }
            ClickTurn(BottomRightBox);
        }
    }
}