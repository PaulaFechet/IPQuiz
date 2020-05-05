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
            i++;   
        }


        public string showQuizz(int i)
        {
            // Daca nu mai sunt intrebari, termin programul cu form EndGame
            if (i <= 10)
            {
                string answer1, answer2, answer3, answer4 = "";
                string _correctAnswer = "";
                Domain choosenDomain = quizz.getDomain(_domainName);
                var domainQuestion = " ";
                choosenDomain.Questions();
                
                // raspunsurile corecte sunt notate cu *
                // nu afisam raspunsurile corecte catre jucator
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
            }
            else
            {
                this.Hide();
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
