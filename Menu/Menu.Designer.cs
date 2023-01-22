namespace Игра
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartGameButton = new System.Windows.Forms.Button();
            this.CloseGameButton = new System.Windows.Forms.Button();
            this.Background = new System.Windows.Forms.Panel();
            this.TicTacToe = new System.Windows.Forms.Label();
            this.Background.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartGameButton
            // 
            this.StartGameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartGameButton.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartGameButton.Location = new System.Drawing.Point(583, 352);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(300, 100);
            this.StartGameButton.TabIndex = 0;
            this.StartGameButton.Text = "Начать игру";
            this.StartGameButton.UseVisualStyleBackColor = true;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // CloseGameButton
            // 
            this.CloseGameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CloseGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseGameButton.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CloseGameButton.Location = new System.Drawing.Point(583, 491);
            this.CloseGameButton.Name = "CloseGameButton";
            this.CloseGameButton.Size = new System.Drawing.Size(300, 100);
            this.CloseGameButton.TabIndex = 1;
            this.CloseGameButton.Text = "Выйти";
            this.CloseGameButton.UseVisualStyleBackColor = true;
            this.CloseGameButton.Click += new System.EventHandler(this.CloseGameButton_Click);
            // 
            // Background
            // 
            this.Background.Controls.Add(this.TicTacToe);
            this.Background.Controls.Add(this.StartGameButton);
            this.Background.Controls.Add(this.CloseGameButton);
            this.Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(1500, 1000);
            this.Background.TabIndex = 3;
            this.Background.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Background_MouseDown);
            this.Background.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Background_MouseMove);
            // 
            // TicTacToe
            // 
            this.TicTacToe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TicTacToe.AutoSize = true;
            this.TicTacToe.Font = new System.Drawing.Font("Segoe UI Black", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TicTacToe.Location = new System.Drawing.Point(485, 100);
            this.TicTacToe.Name = "TicTacToe";
            this.TicTacToe.Size = new System.Drawing.Size(532, 128);
            this.TicTacToe.TabIndex = 2;
            this.TicTacToe.Text = "TicTacToe";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 1000);
            this.Controls.Add(this.Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResizeBegin += new System.EventHandler(this.Menu_Resize);
            this.ResizeEnd += new System.EventHandler(this.Menu_Resize);
            this.Resize += new System.EventHandler(this.Menu_Resize);
            this.Background.ResumeLayout(false);
            this.Background.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button StartGameButton;
        private Button CloseGameButton;
        private Panel Background;
        private Label TicTacToe;
    }
}