/**************************************************************************
 *                                                                        *
 *  File:        FormStart.cs                                             *
 *  Copyright:   (c) 2020, IP Project                                     *
 *  Authors:       Fechet Paula                                           *
 *                 Maftei Claudia                                         *
 *                 Radu Cosmina                                           *
 *                 Burbulea Ioana                                         *
 *                                                                        *
 *  Description: General Knowldege Quiz using Fabric Method Pattern       *
 *                This is used to create the quiz form and display        *
 *                the questions                                           *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/
using QuizzFactoryy;
using ConcreteQuizzFactoryy;
using Domainn;
using System;
using System.Windows.Forms;

namespace quizz
{
    public partial class FormStart : Form
    {
        private int i = 0;
        private int score = 0;
        private QuizzFactory quizz;
        private string _domainName;
        private string _correctAnswer;

        public FormStart(string domainName)
        {
            InitializeComponent();
            _domainName = domainName;
            domainNameButton.Text = domainName;
            quizz = new ConcreteQuizzFactory();
            _correctAnswer = showQuizz(i);

            //trebuie sa trecem la urmatoarea intrebare
            i++;   
        }


        public string showQuizz(int i)
        {
            
           
            string answer1, answer2, answer3, answer4 = "";
            string _correctAnswer = "";
            Domain choosenDomain = quizz.getDomain(_domainName);
            if (i < choosenDomain.getQuestionNumber)
            {
                var domainQuestion = " ";
                choosenDomain.Questions();
                domainQuestion = choosenDomain.getQuestion(i);
                this.questionBtt.Text = domainQuestion;
                answer1 = choosenDomain.getAnswer(i, 1);
                answer2 = choosenDomain.getAnswer(i, 2);
                answer3 = choosenDomain.getAnswer(i, 3);
                answer4 = choosenDomain.getAnswer(i, 4);
                this.answer1.Text = answer1;
                this.answer2.Text = answer2;
                this.answer3.Text = answer3;
                this.answer4.Text = answer4;

                // raspunsurile corecte sunt notate cu *
                // nu afisam raspunsurile corecte catre jucator
                //aceasta notatie ne ajuta la calcularea scorului 

                if (answer1.StartsWith("*"))
                {
                    answer1 = answer1.Substring(1, answer1.Length - 1);
                    this.answer1.Text = answer1;
                    _correctAnswer = "answer1";
                    return _correctAnswer;
                }
                else
                {
                    if (answer2.StartsWith("*"))
                    {
                        answer2 = answer2.Substring(1, answer2.Length - 1);
                        this.answer2.Text = answer2;
                        _correctAnswer = "answer2";
                        return _correctAnswer;
                    }
                    else
                    {
                        if (answer3.StartsWith("*"))
                        {
                            answer3 = answer3.Substring(1, answer3.Length - 1);
                            this.answer3.Text = answer3;
                            _correctAnswer = "answer3";
                            return _correctAnswer;
                        }
                        else
                        {
                            answer4 = answer4.Substring(1, answer4.Length - 1);
                            this.answer4.Text = answer4;
                            _correctAnswer = "answer4";
                            return _correctAnswer;
                        }
                    }
                }
            } else
            {
                this.Hide();

                //dorim finalizarea jocului odata cu terminarea intrebarilor
                Form FormEndGame = new FormEndGame(Convert.ToString(score));
                FormEndGame.Show();
                return "End game.";
            }
           
        }

        private void questionButton_Click(object sender, EventArgs e)
        {

        }

        private void answer3_Click(object sender, EventArgs e)
        {
            //raspunsul e returnat de intrebarea precedenta, retinem starea anterioara
            _correctAnswer = showQuizz(i-1);
            if (_correctAnswer == "answer3")
            {
                score++;
            }
            
            showQuizz(i);
            i++;
        }

        private void answer1_Click(object sender, EventArgs e)
        {
            //raspunsul e returnat de intrebarea precedenta, retinem starea anterioara
            _correctAnswer = showQuizz(i-1);
            if (_correctAnswer == "answer1")
            {
                score++;
            }
            showQuizz(i);
            i++;
            
        }

        private void answer2_Click(object sender, EventArgs e)
        {
            //raspunsul e returnat de intrebarea precedenta, retinem starea anterioara
            _correctAnswer = showQuizz(i - 1);
            if (_correctAnswer == "answer2")
            {
                score++;
            }
            showQuizz(i);
            i++;
        }

        private void answer4_Click(object sender, EventArgs e)
        {
            //raspunsul e returnat de intrebarea precedenta, retinem starea anterioara
            _correctAnswer = showQuizz(i - 1);
            if (_correctAnswer == "answer4")
            {
                score++;
            }
            showQuizz(i);
            i++;
        }
    }
}
