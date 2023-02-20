namespace Игра
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private int turnCount = 0;
        private string turn = "x";
        private string[] win = new string[9];

        private void WinnerTurn(int x, int y, int z)
        {
            if (win[x] == win[y] && win[y] == win[z])
            {
                if (win[x] == "x")
                {
                    RedWin();
                }
                else if (win[x] == "o")
                {
                    BlueWin();
                }
            }
        }

        private void EndGame()
        {
            WinnerTurn(0, 1, 2);
            WinnerTurn(3, 4, 5);
            WinnerTurn(6, 7, 8);
            WinnerTurn(0, 3, 6);
            WinnerTurn(1, 4, 7);
            WinnerTurn(2, 5, 8);
            WinnerTurn(0, 4, 8);
            WinnerTurn(2, 4, 6);
            Draw();
        }

        private void Draw()
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

        private void RedWin()
        {
            EndGame endGame = new();
            endGame.WinnerColor.Text = "Красный";
            endGame.WinnerColor.Left = (this.ClientSize.Width - endGame.WinnerColor.Width) / 2;
            endGame.WinnerColor.Top = (this.ClientSize.Height - endGame.WinnerColor.Height) / 3;
            endGame.WinnerColor.ForeColor = Color.Red;
            endGame.Show();
            this.Hide();
        }

        private void BlueWin()
        {
            EndGame endGame = new();
            endGame.WinnerColor.Text = "Синий";
            endGame.WinnerColor.Left = (this.ClientSize.Width - endGame.WinnerColor.Width) / 2;
            endGame.WinnerColor.Top = (this.ClientSize.Height - endGame.WinnerColor.Height) / 3;
            endGame.WinnerColor.ForeColor = Color.Blue;
            endGame.Show();
            this.Hide();
        }

        private void ClickTurn(PictureBox pictureBox)
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