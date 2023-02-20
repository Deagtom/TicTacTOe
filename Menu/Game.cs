namespace Игра
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            Start();
        }

        readonly EndGame endGame = new EndGame();
        readonly private PictureBox[] pictureBoxes = new PictureBox[9];

        private int turnCount = 0;
        private string turn = "x";
        private bool flag = true;
        private string[] moves = new string[9];

        private void Start()
        {
            pictureBoxes[0] = TopLeftBox;
            pictureBoxes[1] = TopBox;
            pictureBoxes[2] = TopRightBox;
            pictureBoxes[3] = LeftBox;
            pictureBoxes[4] = MiddleBox;
            pictureBoxes[5] = RightBox;
            pictureBoxes[6] = BottomLeftBox;
            pictureBoxes[7] = BottomBox;
            pictureBoxes[8] = BottomRightBox;
        }

        private void WinnerTurn(int x, int y, int z)
        {
            if (moves[x] == moves[y] && moves[y] == moves[z])
            {
                if (moves[x] == "x")
                {
                    RedWin();
                }
                else if (moves[x] == "o")
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
            if (turnCount == 8 && flag)
            {
                flag = false;
                endGame.WinnerColor.Text = "Ничья";
                endGame.WinnerLabel.Hide();
                endGame.Show();
                this.Hide();
            }
        }

        private void RedWin()
        {
            flag = false;
            endGame.WinnerColor.Text = "Красный";
            endGame.WinnerColor.Left = (this.ClientSize.Width - endGame.WinnerColor.Width) / 2;
            endGame.WinnerColor.Top = (this.ClientSize.Height - endGame.WinnerColor.Height) / 3;
            endGame.WinnerColor.ForeColor = Color.Red;
            endGame.Show();
            this.Hide();
        }

        private void BlueWin()
        {
            flag = false;
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
                for (int i = 0; i < pictureBoxes.Length; i++)
                {
                    if (pictureBox == pictureBoxes[i])
                    {
                        moves[i] = "x";
                    }
                }
                EndGame();
                turn = "o";
                turnCount += 1;
            }
            else if (turn == "o" && pictureBox.Image == null)
            {
                pictureBox.Image = Properties.Resources.Круг;
                WhoTurnPicture.Image = Properties.Resources.Крестик;
                for (int i = 0; i < pictureBoxes.Length; i++)
                {
                    if (pictureBox == pictureBoxes[i])
                    {
                        moves[i] = "o";
                    }
                }
                EndGame();
                turn = "x";
                turnCount += 1;
            }
        }

        private void TopLeft_Click(object sender, EventArgs e)
        {
            ClickTurn(TopLeftBox);
        }

        private void Top_Click(object sender, EventArgs e)
        {
            ClickTurn(TopBox);
        }

        private void TopRight_Click(object sender, EventArgs e)
        {
            ClickTurn(TopRightBox);
        }

        private void Left_Click(object sender, EventArgs e)
        {
            ClickTurn(LeftBox);
        }

        private void Middle_Click(object sender, EventArgs e)
        {
            ClickTurn(MiddleBox);
        }

        private void Right_Click(object sender, EventArgs e)
        {
            ClickTurn(RightBox);
        }

        private void BottomLeft_Click(object sender, EventArgs e)
        {
            ClickTurn(BottomLeftBox);
        }

        private void Bottom_Click(object sender, EventArgs e)
        {
            ClickTurn(BottomBox);
        }

        private void BottomRight_Click(object sender, EventArgs e)
        {
            ClickTurn(BottomRightBox);
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
    }
}