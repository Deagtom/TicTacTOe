namespace Игра
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }
        int turnCount = 0;
        string turn = "x";
        string[] win = new string[9];

        private void EndGame()
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
            else if (win[3] == win[4] && win[4] == win[5])
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
            else if (win[6] == win[7] && win[7] == win[8])
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
            else if (win[0] == win[3] && win[3] == win[6])
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
            else if (win[1] == win[4] && win[4] == win[7])
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
            else if (win[2] == win[5] && win[5] == win[8])
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
            else if (win[0] == win[4] && win[4] == win[8])
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
            else if (win[2] == win[4] && win[4] == win[6])
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

        private void Draw()
        {
            if (turnCount == 8)
            {
                MessageBox.Show("Ничья", "Спасибо за игру", MessageBoxButtons.OK);
                Menu menu = new Menu();
                menu.Show();
                this.Close();
            }
        }

        private void RedWin()
        {
            MessageBox.Show("Победил Красный", "Поздравляю!", MessageBoxButtons.OK);
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void BlueWin()
        {
            MessageBox.Show("Победил Синий", "Поздравляю!", MessageBoxButtons.OK);
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void Click(PictureBox pictureBox)
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

        private void Close()
        {
            Menu Menu = new Menu();
            Menu.Show();
            this.Hide();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
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
            else if (turn == "o")
            {
                win[0] = "o";
            }
            Click(pictureBox1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (turn == "x")
            {
                win[1] = "x";
            }
            else if (turn == "o")
            {
                win[1] = "o";
            }
            Click(pictureBox2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (turn == "x")
            {
                win[2] = "x";
            }
            else if (turn == "o")
            {
                win[2] = "o";
            }
            Click(pictureBox3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (turn == "x")
            {
                win[3] = "x";
            }
            else if (turn == "o")
            {
                win[3] = "o";
            }
            Click(pictureBox4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (turn == "x")
            {
                win[4] = "x";
            }
            else if (turn == "o")
            {
                win[4] = "o";
            }
            Click(pictureBox5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (turn == "x")
            {
                win[5] = "x";
            }
            else if (turn == "o")
            {
                win[5] = "o";
            }
            Click(pictureBox6);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (turn == "x")
            {
                win[6] = "x";
            }
            else if (turn == "o")
            {
                win[6] = "o";
            }
            Click(pictureBox7);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (turn == "x")
            {
                win[7] = "x";
            }
            else if (turn == "o")
            {
                win[7] = "o";
            }
            Click(pictureBox8);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (turn == "x")
            {
                win[8] = "x";
            }
            else if (turn == "o")
            {
                win[8] = "o";
            }
            Click(pictureBox9);
        }
    }
}