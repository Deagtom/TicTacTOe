﻿using System.Windows.Forms;

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

        Random random = new Random();
        EndGame endGame = new EndGame();

        private List<PictureBox> pictureBoxes = new List<PictureBox>();
        private string[] moves = new string[9];

        public string turn = string.Empty;
        private int turnCount = 0,
                    indexTurn = 0;

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
            if (turnCount == 8)
            {
                endGame.WinnerColor.Text = "Ничья";
                endGame.WinnerLabel.Hide();
                endGame.Show();
                this.Hide();
            }
        }
        private void RedWin()
        {
            endGame.WinnerColor.Text = "Красный";
            endGame.WinnerColor.Left = (this.ClientSize.Width - endGame.WinnerColor.Width) / 2;
            endGame.WinnerColor.Top = (this.ClientSize.Height - endGame.WinnerColor.Height) / 3;
            endGame.WinnerColor.ForeColor = Color.Red;
            endGame.Show();
            this.Hide();
        }

        private void BlueWin()
        {
            endGame.WinnerColor.Text = "Синий";
            endGame.WinnerColor.Left = (this.ClientSize.Width - endGame.WinnerColor.Width) / 2;
            endGame.WinnerColor.Top = (this.ClientSize.Height - endGame.WinnerColor.Height) / 3;
            endGame.WinnerColor.ForeColor = Color.Blue;
            endGame.Show();
            this.Hide();
        }

        private void ClickTurnX(PictureBox pictureBox)
        {
            if (turn == "x" && pictureBox.Image == null)
            {
                pictureBox.Image = Properties.Resources.Крестик;
                WhoTurnPicture.Image = Properties.Resources.Круг;
                for (int i = 0; i < pictureBoxes.Count; i++)
                {
                    if (pictureBox == pictureBoxes[i])
                    {
                        moves[i] = "x";
                    }
                }
                EndGame();
                turn = "o";
                turnCount += 1;
                pictureBoxes.Remove(pictureBox);
                pictureBox.Enabled = false;
            }
        }

        private async Task ClickTurnO(PictureBox pictureBox)
        {
            if (turn == "o" && pictureBoxes.Count != 0)
            {
                await Task.Delay(random.Next(250, 1000));
                indexTurn = random.Next(pictureBoxes.Count());
                pictureBox = pictureBoxes[indexTurn];
                pictureBox.Image = Properties.Resources.Круг;
                WhoTurnPicture.Image = Properties.Resources.Крестик;
                for (int i = 0; i < pictureBoxes.Count; i++)
                {
                    if (pictureBox == pictureBoxes[i])
                    {
                        moves[i] = "o";
                    }
                }
                EndGame();
                turn = "x";
                turnCount += 1;
                pictureBoxes.Remove(pictureBox);
                pictureBox.Enabled = false;
            }
        }

        private void TopLeft_Click(object sender, EventArgs e)
        {
            ClickTurnX(TopLeftBox);
            ClickTurnO(TopLeftBox);
        }

        private void Top_Click(object sender, EventArgs e)
        {
            ClickTurnX(TopBox);
            ClickTurnO(TopBox);
        }

        private void TopRight_Click(object sender, EventArgs e)
        {
            ClickTurnX(TopRightBox);
            ClickTurnO(TopRightBox);
        }

        private void Left_Click(object sender, EventArgs e)
        {
            ClickTurnX(LeftBox);
            ClickTurnO(LeftBox);
        }

        private void Middle_Click(object sender, EventArgs e)
        {
            ClickTurnX(MiddleBox);
            ClickTurnO(MiddleBox);
        }

        private void Right_Click(object sender, EventArgs e)
        {
            ClickTurnX(RightBox);
            ClickTurnO(RightBox);
        }

        private void BottomLeft_Click(object sender, EventArgs e)
        {
            ClickTurnX(BottomLeftBox);
            ClickTurnO(BottomLeftBox);
        }

        private void Bottom_Click(object sender, EventArgs e)
        {
            ClickTurnX(BottomBox);
            ClickTurnO(BottomBox);
        }

        private void BottomRight_Click(object sender, EventArgs e)
        {
            ClickTurnX(BottomRightBox);
            ClickTurnO(BottomRightBox);
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