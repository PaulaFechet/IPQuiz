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

        private void button1_Click(object sender, EventArgs e)
        {
            FormStart newFormS = new FormStart();
            newFormS.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormStart newFormS = new FormStart();
            newFormS.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormStart newFormS = new FormStart();
            newFormS.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormStart newFormS = new FormStart();
            newFormS.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
