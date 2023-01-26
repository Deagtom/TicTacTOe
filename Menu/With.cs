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

        public int turnCount = 0;
        public string turn = "x";
        public string[] win = new string[9];
        public List<PictureBox> pictureBoxes = new List<PictureBox>();
        public int indexTurn = 0;

        private void Start()
        {
            pictureBoxes.Add(pictureBox1);
            pictureBoxes.Add(pictureBox2);
            pictureBoxes.Add(pictureBox3);
            pictureBoxes.Add(pictureBox4);
            pictureBoxes.Add(pictureBox5);
            pictureBoxes.Add(pictureBox6);
            pictureBoxes.Add(pictureBox7);
            pictureBoxes.Add(pictureBox8);
            pictureBoxes.Add(pictureBox9);
        }
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
                EndGame endGame = new EndGame();
                endGame.WinnerColor.Text = "Ничья";
                endGame.WinnerLabel.Hide();
                endGame.Show();
                this.Hide();
            }
        }

        public void RedWin()
        {
            EndGame endGame = new EndGame();
            endGame.WinnerColor.Text = "Красный";
            endGame.WinnerColor.Left = (this.ClientSize.Width - endGame.WinnerColor.Width) / 2;
            endGame.WinnerColor.Top = (this.ClientSize.Height - endGame.WinnerColor.Height) / 3;
            endGame.WinnerColor.ForeColor = Color.Red;
            endGame.Show();
            this.Hide();
        }

        public void BlueWin()
        {
            EndGame endGame = new EndGame();
            endGame.WinnerColor.Text = "Синий";
            endGame.WinnerColor.Left = (this.ClientSize.Width - endGame.WinnerColor.Width) / 2;
            endGame.WinnerColor.Top = (this.ClientSize.Height - endGame.WinnerColor.Height) / 3;
            endGame.WinnerColor.ForeColor = Color.Blue;
            endGame.Show();
            this.Hide();
        }

        async Task Click(PictureBox pictureBox)
        {
            Random random = new Random();

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
            if (turn == "o")
            {
                indexTurn = random.Next(pictureBoxes.Count());
                await Task.Delay(random.Next(200, 1000));
                pictureBox = pictureBoxes[indexTurn];
                if (pictureBox == pictureBox1)
                {
                    win[0] = "o";
                }
                else if (pictureBox == pictureBox2)
                {
                    win[1] = "o";
                }
                else if (pictureBox == pictureBox3)
                {
                    win[2] = "o";
                }
                else if (pictureBox == pictureBox4)
                {
                    win[3] = "o";
                }
                else if (pictureBox == pictureBox5)
                {
                    win[4] = "o";
                }
                else if (pictureBox == pictureBox6)
                {
                    win[5] = "o";
                }
                else if (pictureBox == pictureBox7)
                {
                    win[6] = "o";
                }
                else if (pictureBox == pictureBox8)
                {
                    win[7] = "o";
                }
                else if (pictureBox == pictureBox9)
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
            Close();
        }

        private void Close()
        {
            Menu Menu = new Menu();
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

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (turn == "x")
            {
                win[0] = "x";
            }
            Click(pictureBox1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (turn == "x")
            {
                win[1] = "x";
            }
            Click(pictureBox2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (turn == "x")
            {
                win[2] = "x";
            }
            Click(pictureBox3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (turn == "x")
            {
                win[3] = "x";
            }
            Click(pictureBox4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (turn == "x")
            {
                win[4] = "x";
            }
            Click(pictureBox5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (turn == "x")
            {
                win[5] = "x";
            }
            Click(pictureBox6);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (turn == "x")
            {
                win[6] = "x";
            }
            Click(pictureBox7);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (turn == "x")
            {
                win[7] = "x";
            }
            Click(pictureBox8);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (turn == "x")
            {
                win[8] = "x";
            }
            Click(pictureBox9);
        }
    }
}