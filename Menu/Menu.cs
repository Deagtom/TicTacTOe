namespace Игра
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.Show();
            this.Hide();
        }

        private void CloseGameButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point lastPoint;
        private void Background_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Background_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Menu_Resize(object sender, EventArgs e)
        {
            StartGameButton.Left = this.ClientSize.Width / 2 - StartGameButton.Width / 2;
            StartGameButton.Top = this.ClientSize.Height / 2 - StartGameButton.Height / 2;
        }
    }
}
