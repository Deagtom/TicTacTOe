namespace Игра
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
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

        private void StartGameWitchPC_Click(object sender, EventArgs e)
        {
            With with = new With();
            with.Show();
            this.Hide();
        }
    }
}
