namespace Игра
{
    partial class Turn
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
            this.TurnOButton = new System.Windows.Forms.Button();
            this.TurnLabel = new System.Windows.Forms.Label();
            this.TurnXButton = new System.Windows.Forms.Button();
            this.Background.SuspendLayout();
            this.SuspendLayout();
            // 
            // Background
            // 
            this.Background.Controls.Add(this.TurnOButton);
            this.Background.Controls.Add(this.TurnLabel);
            this.Background.Controls.Add(this.TurnXButton);
            this.Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Background.Location = new System.Drawing.Point(0, 0);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(1500, 1000);
            this.Background.TabIndex = 0;
            // 
            // TurnOButton
            // 
            this.TurnOButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TurnOButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TurnOButton.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TurnOButton.Location = new System.Drawing.Point(792, 465);
            this.TurnOButton.Name = "TurnOButton";
            this.TurnOButton.Size = new System.Drawing.Size(129, 100);
            this.TurnOButton.TabIndex = 6;
            this.TurnOButton.Text = "O";
            this.TurnOButton.UseVisualStyleBackColor = true;
            this.TurnOButton.Click += new System.EventHandler(this.TurnOButton_Click);
            // 
            // TurnLabel
            // 
            this.TurnLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TurnLabel.AutoSize = true;
            this.TurnLabel.Font = new System.Drawing.Font("Segoe UI Black", 64F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TurnLabel.Location = new System.Drawing.Point(342, 246);
            this.TurnLabel.Name = "TurnLabel";
            this.TurnLabel.Size = new System.Drawing.Size(905, 114);
            this.TurnLabel.TabIndex = 5;
            this.TurnLabel.Text = "Кто ходит первым?";
            // 
            // TurnXButton
            // 
            this.TurnXButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TurnXButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TurnXButton.Font = new System.Drawing.Font("Segoe UI Semibold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TurnXButton.Location = new System.Drawing.Point(605, 465);
            this.TurnXButton.Name = "TurnXButton";
            this.TurnXButton.Size = new System.Drawing.Size(129, 100);
            this.TurnXButton.TabIndex = 4;
            this.TurnXButton.Text = "X";
            this.TurnXButton.UseVisualStyleBackColor = true;
            this.TurnXButton.Click += new System.EventHandler(this.TurnXButton_Click);
            // 
            // Turn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1500, 1000);
            this.Controls.Add(this.Background);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Turn";
            this.Text = "Turn";
            this.Background.ResumeLayout(false);
            this.Background.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel Background;
        private Button TurnOButton;
        private Label TurnLabel;
        private Button TurnXButton;
    }
}