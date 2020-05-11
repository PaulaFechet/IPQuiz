/**************************************************************************
 *                                                                        *
 *  File:        FormMenu.cs                                              *
 *  Copyright:   (c) 2020, IP Project                                     *
 *  Authors:       Fechet Paula                                           *
 *                 Maftei Claudia                                         *
 *                 Radu Cosmina                                           *
 *                 Burbulea Ioana                                         *
 *                                                                        *
 *  Description: General Knowldege Quiz using Fabric Method Pattern       *
 *               it allows you to choose from the menu which consists of  *
 *               the name of the domains: Chemistry, Art, History, Arts   *
 *               Choose one to play.                                      *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/


using System;
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
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void chemistryButton_Click(object sender, EventArgs e)
        {
            //determinarea tipului de quiz 
            FormStart chemistryQuizz = new FormStart("chimie");
            this.Hide();
            //inceperea jocului de cultura generala
            chemistryQuizz.Show();
        }

        private void ITButton_Click(object sender, EventArgs e)
        {
            //determinarea tipului de quiz 
            FormStart ITQuizz = new FormStart("it");
            this.Hide();
            //inceperea jocului de cultura generala
            ITQuizz.Show();
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            //determinarea tipului de quiz 
            FormStart historyQuizz = new FormStart("istorie");
            this.Hide();
            //inceperea jocului de cultura generala
            historyQuizz.Show();
        }

        private void artsButton_Click(object sender, EventArgs e)
        {
            //determinarea tipului de quiz 
            FormStart artsQuizz = new FormStart("arte");
            this.Hide();
            //inceperea jocului de cultura generala
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
