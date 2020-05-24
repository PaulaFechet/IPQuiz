/**************************************************************************
 *                                                                        *
 *  File:        FormEndGame.cs                                           *
 *  Copyright:   (c) 2020, IP Project                                     *
 *  Authors:       Fechet Paula                                           *
 *                 Maftei Claudia                                         *
 *                 Radu Cosmina                                           *
 *                 Burbulea Ioana                                         *
 *                                                                        *
 *  Description: General Knowldege Quiz using Fabric Method Pattern       *
 *                This is used to create the end forum page for           *
 *                the quiz game                                           *
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
    /// <summary>
    /// Form for end of the game
    /// </summary>
    public partial class FormEndGame : Form
    {
        public FormEndGame(string score)
        {
            InitializeComponent();
            //punctajul maxim este 20
            scoreButton.Text = "You scored " + score + "/20";

        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            //form de reincepere a jocului
            //scorul reincepe de la 0
            FormMenu menu = new quizz.FormMenu();
            menu.Show();
            
        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            
        }

        private void endGameButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
