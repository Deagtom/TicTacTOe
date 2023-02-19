namespace Игра
{
    public partial class With : Form
    {
        public With()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Start();
        }

        public bool flag = true;
        public int turnCount = 0;
        public string turn = "x";
        public string[] win = new string[9];
        public List<PictureBox> pictureBoxes = new();
        public int indexTurn = 0;

        private void Start()
        {
            pictureBoxes.Add(TopLeftBox);
            pictureBoxes.Add(TopBox);
            pictureBoxes.Add(TopRightBox);
            pictureBoxes.Add(LeftBox);
            pictureBoxes.Add(MiddleBox);
            pictureBoxes.Add(RightBox);
            pictureBoxes.Add(BottomLeftBox);
            pictureBoxes.Add(BottomBox);
            pictureBoxes.Add(BottomRightBox);
        }
        public void EndGame()
        {
            EndGame endGame = new();
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
            if (turnCount == 8 && endGame.WinnerColor.Text != "Красный" && endGame.WinnerColor.Text != "Синий")
            {
                flag = false;
                endGame.WinnerColor.Text = "Ничья";
                endGame.WinnerLabel.Hide();
                endGame.Show();
                this.Hide();
            }
        }

        public void RedWin()
        {
            flag = false;
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
            flag = false;
            EndGame endGame = new();
            endGame.WinnerColor.Text = "Синий";
            endGame.WinnerColor.Left = (this.ClientSize.Width - endGame.WinnerColor.Width) / 2;
            endGame.WinnerColor.Top = (this.ClientSize.Height - endGame.WinnerColor.Height) / 3;
            endGame.WinnerColor.ForeColor = Color.Blue;
            endGame.Show();
            this.Hide();
        }

        async Task ClickTurn(PictureBox pictureBox)
        {
            Random random = new();

            if (turn == "x" && pictureBox.Image == null)
            {
                pictureBox.Image = Properties.Resources.Крестик;
                Bitmap круг = Properties.Resources.Круг;
                WhoTurnPicture.Image = круг;
                EndGame();
                turn = "o";
                turnCount += 1;
                pictureBoxes.Remove(pictureBox);
                pictureBox.Enabled = false;
            }
            if (turn == "o" && flag)
            {
                indexTurn = random.Next(pictureBoxes.Count());
                await Task.Delay(random.Next(200, 1000));
                pictureBox = pictureBoxes[indexTurn];
                if (pictureBox == TopLeftBox)
                {
                    win[0] = "o";
                }
                else if (pictureBox == TopBox)
                {
                    win[1] = "o";
                }
                else if (pictureBox == TopRightBox)
                {
                    win[2] = "o";
                }
                else if (pictureBox == LeftBox)
                {
                    win[3] = "o";
                }
                else if (pictureBox == MiddleBox)
                {
                    win[4] = "o";
                }
                else if (pictureBox == RightBox)
                {
                    win[5] = "o";
                }
                else if (pictureBox == BottomLeftBox)
                {
                    win[6] = "o";
                }
                else if (pictureBox == BottomBox)
                {
                    win[7] = "o";
                }
                else if (pictureBox == BottomRightBox)
                {
                    win[8] = "o";
                }
                pictureBox.Image = Properties.Resources.Круг;
                pictureBoxes.Remove(pictureBox);
                WhoTurnPicture.Image = Properties.Resources.Крестик;
                EndGame();
                turn = "x";
                turnCount += 1;
                pictureBox.Enabled = false;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            CloseGame();
        }

        private void CloseGame()
        {
            Menu Menu = new();
            Menu.Show();
            this.Hide();
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
            ClickTurn(TopLeftBox);
        }

        private void Top_Click(object sender, EventArgs e)
        {
            if (turn == "x")
            {
                win[1] = "x";
            }
            ClickTurn(TopBox);
        }

        private void TopRight_Click(object sender, EventArgs e)
        {
            if (turn == "x")
            {
                win[2] = "x";
            }
            ClickTurn(TopRightBox);
        }

        private void Left_Click(object sender, EventArgs e)
        {
            if (turn == "x")
            {
                win[3] = "x";
            }
            ClickTurn(LeftBox);
        }

        private void Middle_Click(object sender, EventArgs e)
        {
            if (turn == "x")
            {
                win[4] = "x";
            }
            ClickTurn(MiddleBox);
        }

        private void Right_Click(object sender, EventArgs e)
        {
            if (turn == "x")
            {
                win[5] = "x";
            }
            ClickTurn(RightBox);
        }

        private void BottomLeft_Click(object sender, EventArgs e)
        {
            if (turn == "x")
            {
                win[6] = "x";
            }
            ClickTurn(BottomLeftBox);
        }

        private void Bottom_Click(object sender, EventArgs e)
        {
            if (turn == "x")
            {
                win[7] = "x";
            }
            ClickTurn(BottomBox);
        }

        private void BottomRight_Click(object sender, EventArgs e)
        {
            if (turn == "x")
            {
                win[8] = "x";
            }
            ClickTurn(BottomRightBox);
        }
    }
}