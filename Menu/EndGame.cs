﻿namespace Игра
{
    public partial class EndGame : Form
    {
        public EndGame()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void CloseGame()
        {
            Menu Menu = new Menu();
            Menu.Show();
            this.Hide();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            CloseGame();
        }
    }
}
