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
    public partial class FormEndGame : Form
    {
        public FormEndGame(string score)
        {
            InitializeComponent();
            scoreButton.Text = "You scored "+score+ "/11";
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu menu = new quizz.FormMenu();
            menu.Show();
            
        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
