using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizz
{
    class History:Domain
    {
        //private readonly string _domainName;
        private string[,] questions = new string[20, 5];

        public override string domainName
        {
            get
            {
                return "History";
            }
        }

        public override void Questions()
        {

            Console.WriteLine("History questions.");
            //
            questions[0, 0] = "In what year did Christopher Columbus discover the New World?";
            questions[0, 1] = "1495";
            questions[0, 2] = "*1492";
            questions[0, 3] = "1460";
            questions[0, 4] = "1462";
            //
            questions[1, 0] = "On September 24, 1906 President Theodore Roosevelt established the first US national monument. What was it?";
            questions[1, 1] = "*Devils Tower in Wyoming";
            questions[1, 2] = "Bandelier";
            questions[1, 3] = "Browns Canyon";
            questions[1, 4] = "Buck Island Reef";
            //
            questions[2, 0] = "Which city is traditionally said to be built on seven hills?";
            questions[2, 1] = "Paris";
            questions[2, 2] = "*Rome";
            questions[2, 3] = "New York";
            questions[2, 4] = "Bucharest";
            //
            questions[3, 0] = "The atomic bomb was dropped on Hiroshima in which decade?";
            questions[3, 1] = "*1940's";
            questions[3, 2] = "1960's";
            questions[3, 3] = "1980's";
            questions[3, 4] = "1950's";
            //
            questions[4, 0] = "In 1893, which country became the first to give women the right to vote?";
            questions[4, 1] = "Romania";
            questions[4, 2] = "*New Zealand";
            questions[4, 3] = "Italy";
            questions[4, 4] = "Germany";
            //
            questions[5, 0] = "What famous actor became Governor of California in 2003?";
            questions[5, 1] = "Leonardo DiCaprio";
            questions[5, 2] = "Tom Hanks";
            questions[5, 3] = "*Arnold Schwarzenegger";
            questions[5, 4] = "Robert De Niro";
            //
            questions[6, 0] = "In what year did Fidel Castro die?";
            questions[6, 1] = "2017";
            questions[6, 2] = "2015";
            questions[6, 3] = "2013";
            questions[6, 4] = "*2016";
            //
            questions[7, 0] = "On September 24, 1906 President Theodore Roosevelt established the first US national monument. What was it?";
            questions[7, 1] = "*Devils Tower in Wyoming";
            questions[7, 2] = "Bandelier";
            questions[7, 3] = "Browns Canyon";
            questions[7, 4] = "Buck Island Reef";
            //
            questions[8, 0] = "How many heads of executive departments make up the president's cabinet - 10, 15, or 25?";
            questions[8, 1] = "*15";
            questions[8, 2] = "20";
            questions[8, 3] = "10";
            questions[8, 4] = "18";
            //
            questions[9, 0] = "Who was the first US President to declare war?";
            questions[9, 1] = "*James Madison";
            questions[9, 2] = "James Monroe";
            questions[9, 3] = "Andrew Jackson";
            questions[9, 4] = "Martin Van Buren";
            //
            questions[10, 0] = "The second atomic bomb ever used in war-time was dropped on what city?";
            questions[10, 1] = "Jackson";
            questions[10, 2] = "*Nagasaki";
            questions[10, 3] = "Denver";
            questions[10, 4] = "London";

        }

        public override string getQuestion(int i)
        {
            return questions[i, 0];
        }

        public override string getAnswer(int i, int j)
        {
            return questions[i, j];
        }

    }
}
