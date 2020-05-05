namespace quizz
{
    partial class FormMenu
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
            this.chemistryButton = new System.Windows.Forms.Button();
            this.ITButton = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.artsButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chemistryButton
            // 
            this.chemistryButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chemistryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chemistryButton.Location = new System.Drawing.Point(184, 41);
            this.chemistryButton.Margin = new System.Windows.Forms.Padding(2);
            this.chemistryButton.Name = "chemistryButton";
            this.chemistryButton.Size = new System.Drawing.Size(114, 37);
            this.chemistryButton.TabIndex = 0;
            this.chemistryButton.Text = "Chimie";
            this.chemistryButton.UseVisualStyleBackColor = false;
            this.chemistryButton.Click += new System.EventHandler(this.chemistryButton_Click);
            // 
            // ITButton
            // 
            this.ITButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ITButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ITButton.Location = new System.Drawing.Point(184, 84);
            this.ITButton.Margin = new System.Windows.Forms.Padding(2);
            this.ITButton.Name = "ITButton";
            this.ITButton.Size = new System.Drawing.Size(114, 38);
            this.ITButton.TabIndex = 1;
            this.ITButton.Text = "IT";
            this.ITButton.UseVisualStyleBackColor = false;
            this.ITButton.Click += new System.EventHandler(this.ITButton_Click);
            // 
            // historyButton
            // 
            this.historyButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.historyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historyButton.Location = new System.Drawing.Point(184, 127);
            this.historyButton.Margin = new System.Windows.Forms.Padding(2);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(116, 38);
            this.historyButton.TabIndex = 2;
            this.historyButton.Text = "Istorie";
            this.historyButton.UseVisualStyleBackColor = false;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // artsButton
            // 
            this.artsButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.artsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.artsButton.Location = new System.Drawing.Point(186, 170);
            this.artsButton.Margin = new System.Windows.Forms.Padding(2);
            this.artsButton.Name = "artsButton";
            this.artsButton.Size = new System.Drawing.Size(114, 39);
            this.artsButton.TabIndex = 3;
            this.artsButton.Text = "Arta";
            this.artsButton.UseVisualStyleBackColor = false;
            this.artsButton.Click += new System.EventHandler(this.artsButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(156, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Alege un domeniu!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.historyButton);
            this.panel1.Controls.Add(this.artsButton);
            this.panel1.Controls.Add(this.chemistryButton);
            this.panel1.Controls.Add(this.ITButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(64, 46);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 259);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(341, 311);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(155, 44);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.helpButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.ForeColor = System.Drawing.Color.Black;
            this.helpButton.Location = new System.Drawing.Point(129, 311);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(135, 44);
            this.helpButton.TabIndex = 6;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = false;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::quizz.Properties.Resources.dd;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button chemistryButton;
        private System.Windows.Forms.Button ITButton;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.Button artsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button helpButton;
    }
}