﻿namespace Игра
{
    public partial class Turn : Form
    {
        public Turn()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void TurnXButton_Click(object sender, EventArgs e)
        {
            With with = new With();
            with.turn = "x";
            with.Show();
            this.Hide();
        }

        private void TurnOButton_Click(object sender, EventArgs e)
        {
            With with = new With();
            Random random = new Random();
            with.ClickTurnO(with.pictureBoxes[random.Next(with.pictureBoxes.Count)]);
            with.turn = "o";

            with.Show();
            this.Hide();
        }
    }
}
