namespace Игра
{
    partial class EndGame
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
            this.Background = new System.Windows.Forms.Panel();
            this.WinnerLabel = new System.Windows.Forms.Label();
            this.CloseGameButton = new System.Windows.Forms.Button();
            this.WinnerColor = new System.Windows.Forms.Label();
            this.Background.SuspendLayout();
            this.SuspendLayout();
            // 
            // Background
            // 
            this.Background.Controls.Add(this.WinnerLabel);
            this.Background.Controls.Add(this.CloseGameButton);
            this.Background.Controls.Add(this.WinnerColor);
            this.Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(1500, 1000);
            this.Background.TabIndex = 0;
            // 
            // WinnerLabel
            // 
            this.WinnerLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.WinnerLabel.AutoSize = true;
            this.WinnerLabel.Font = new System.Drawing.Font("Segoe UI Black", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.WinnerLabel.Location = new System.Drawing.Point(140, 253);
            this.WinnerLabel.Name = "WinnerLabel";
            this.WinnerLabel.Size = new System.Drawing.Size(498, 128);
            this.WinnerLabel.TabIndex = 31;
            this.WinnerLabel.Text = "Победил";
            // 
            // CloseGameButton
            // 
            this.CloseGameButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CloseGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseGameButton.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CloseGameButton.Location = new System.Drawing.Point(585, 832);
            this.CloseGameButton.Name = "CloseGameButton";
            this.CloseGameButton.Size = new System.Drawing.Size(300, 100);
            this.CloseGameButton.TabIndex = 30;
            this.CloseGameButton.Text = "Назад";
            this.CloseGameButton.UseVisualStyleBackColor = true;
            this.CloseGameButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // WinnerColor
            // 
            this.WinnerColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WinnerColor.AutoSize = true;
            this.WinnerColor.Font = new System.Drawing.Font("Segoe UI Semibold", 128.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.WinnerColor.Location = new System.Drawing.Point(432, 302);
            this.WinnerColor.Name = "WinnerColor";
            this.WinnerColor.Size = new System.Drawing.Size(801, 227);
            this.WinnerColor.TabIndex = 29;
            this.WinnerColor.Text = "Красный";
            // 
            // EndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 1000);
            this.Controls.Add(this.Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EndGame";
            this.Text = "EndGame";
            this.Background.ResumeLayout(false);
            this.Background.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Background;
        public Label WinnerColor;
        private Button CloseGameButton;
        public Label WinnerLabel;
    }
}