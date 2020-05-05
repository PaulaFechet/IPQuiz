using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizz
{
    public partial class FormMenu : Form
    {
        public static string _domainName;
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chemistryButton_Click(object sender, EventArgs e)
        {
            FormStart chemistryQuizz = new FormStart("chimie");
            
            this.Hide();
            
            chemistryQuizz.Show();
        }

        private void ITButton_Click(object sender, EventArgs e)
        {
            FormStart ITQuizz = new FormStart("it");
            this.Hide();
            ITQuizz.Show();
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            FormStart historyQuizz = new FormStart("history");
            this.Hide();
            historyQuizz.Show();
        }

        private void artsButton_Click(object sender, EventArgs e)
        {
            FormStart artsQuizz = new FormStart("arts");
            this.Hide();
            artsQuizz.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {

        }
    }
}
