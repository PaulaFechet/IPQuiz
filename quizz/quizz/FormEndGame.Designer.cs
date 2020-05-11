namespace quizz
{
    partial class FormEndGame
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
            this.endGameButton = new System.Windows.Forms.Button();
            this.scoreButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // endGameButton
            // 
            this.endGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endGameButton.Location = new System.Drawing.Point(151, 45);
            this.endGameButton.Name = "endGameButton";
            this.endGameButton.Size = new System.Drawing.Size(120, 55);
            this.endGameButton.TabIndex = 0;
            this.endGameButton.Text = "End Game";
            this.endGameButton.UseVisualStyleBackColor = true;
            this.endGameButton.Click += new System.EventHandler(this.endGameButton_Click);
            // 
            // scoreButton
            // 
            this.scoreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreButton.Location = new System.Drawing.Point(142, 120);
            this.scoreButton.Name = "scoreButton";
            this.scoreButton.Size = new System.Drawing.Size(147, 62);
            this.scoreButton.TabIndex = 1;
            this.scoreButton.Text = "Score";
            this.scoreButton.UseVisualStyleBackColor = true;
            this.scoreButton.Click += new System.EventHandler(this.scoreButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton.Location = new System.Drawing.Point(166, 218);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(105, 45);
            this.restartButton.TabIndex = 2;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // FormEndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::quizz.Properties.Resources.dd;
            this.ClientSize = new System.Drawing.Size(429, 321);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.scoreButton);
            this.Controls.Add(this.endGameButton);
            this.Name = "FormEndGame";
            this.Text = "FormEndGame";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button endGameButton;
        private System.Windows.Forms.Button scoreButton;
        private System.Windows.Forms.Button restartButton;
    }
}