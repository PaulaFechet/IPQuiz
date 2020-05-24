namespace quizz
{
    partial class FormStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            this.answer1 = new System.Windows.Forms.Button();
            this.answer2 = new System.Windows.Forms.Button();
            this.answer3 = new System.Windows.Forms.Button();
            this.answer4 = new System.Windows.Forms.Button();
            this.questionBtt = new System.Windows.Forms.Button();
            this.domainNameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // answer1
            // 
            this.answer1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.answer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.answer1.Location = new System.Drawing.Point(78, 189);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(205, 86);
            this.answer1.TabIndex = 1;
            this.answer1.Text = "answer1";
            this.answer1.UseVisualStyleBackColor = false;
            this.answer1.Click += new System.EventHandler(this.answer1_Click);
            // 
            // answer2
            // 
            this.answer2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.answer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.answer2.Location = new System.Drawing.Point(482, 189);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(195, 86);
            this.answer2.TabIndex = 2;
            this.answer2.Text = "answer2";
            this.answer2.UseVisualStyleBackColor = false;
            this.answer2.Click += new System.EventHandler(this.answer2_Click);
            // 
            // answer3
            // 
            this.answer3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.answer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.answer3.Location = new System.Drawing.Point(86, 325);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(197, 85);
            this.answer3.TabIndex = 3;
            this.answer3.Text = "answer3";
            this.answer3.UseVisualStyleBackColor = false;
            this.answer3.Click += new System.EventHandler(this.answer3_Click);
            // 
            // answer4
            // 
            this.answer4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.answer4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.answer4.Location = new System.Drawing.Point(482, 327);
            this.answer4.Name = "answer4";
            this.answer4.Size = new System.Drawing.Size(195, 83);
            this.answer4.TabIndex = 4;
            this.answer4.Text = "answer4";
            this.answer4.UseVisualStyleBackColor = false;
            this.answer4.Click += new System.EventHandler(this.answer4_Click);
            // 
            // questionBtt
            // 
            this.questionBtt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.questionBtt.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionBtt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.questionBtt.Location = new System.Drawing.Point(166, 12);
            this.questionBtt.Name = "questionBtt";
            this.questionBtt.Size = new System.Drawing.Size(482, 158);
            this.questionBtt.TabIndex = 5;
            this.questionBtt.Text = "question";
            this.questionBtt.UseVisualStyleBackColor = false;
            // 
            // domainNameButton
            // 
            this.domainNameButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.domainNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.domainNameButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.domainNameButton.Location = new System.Drawing.Point(10, 30);
            this.domainNameButton.Name = "domainNameButton";
            this.domainNameButton.Size = new System.Drawing.Size(137, 33);
            this.domainNameButton.TabIndex = 6;
            this.domainNameButton.Text = "domainName";
            this.domainNameButton.UseVisualStyleBackColor = false;
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.domainNameButton);
            this.Controls.Add(this.questionBtt);
            this.Controls.Add(this.answer4);
            this.Controls.Add(this.answer3);
            this.Controls.Add(this.answer2);
            this.Controls.Add(this.answer1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "FormStart";
            this.Text = "FormStart";
            this.Load += new System.EventHandler(this.FormStart_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button questionButton;
        //public System.Windows.Forms.Button questionButton { get; set; }
        private System.Windows.Forms.Button answer1;
        private System.Windows.Forms.Button answer2;
        private System.Windows.Forms.Button answer3;
        private System.Windows.Forms.Button answer4;
        private System.Windows.Forms.Button questionBtt;
        private System.Windows.Forms.Button domainNameButton;
    }
}