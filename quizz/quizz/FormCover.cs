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
    public partial class FormCover : Form
    {
        public FormCover()
        {
            InitializeComponent();
           
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormMenu newFormM = new FormMenu();
            newFormM.Show();
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
