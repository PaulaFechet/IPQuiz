using System;
namespace quizz
{
    class History:Domain
    {
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
            //raspunsurile corecte sunt notate cu * si vor fi ascunse de jucatori
            //ne vor ajuta la calcularea scorului
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
            //
            questions[11, 0] = "Who did Henry VIII first marry?";
            questions[11, 1] ="*Catherine of Aragon";
            questions[11, 2] ="Meghan Markle";
            questions[11, 3] ="Kate Middleton";
            questions[11, 4] ="Holly Willoughby";
            //
            questions[12, 0] = "Who was the second man to walk on the moon?";
            questions[12, 1] ="*Buzz Aldrin";
            questions[12, 2] ="Neil Armstrong";
            questions[12, 3] ="Mark Hamill";
            questions[12, 4] ="Astronaut Audrey";
            //
            questions[13, 0] = "Where was the explorer Captain James Cook from?";
            questions[13, 1] ="*England";
            questions[13, 2] ="Denmark";
            questions[13, 3] ="Germany";
            questions[13, 4] ="Poland";
            //
            questions[14, 0] = "Which country gave the Statue of Liberty as a gift to the United States of America?";
            questions[14, 1] ="England";
            questions[14, 2] ="*France";
            questions[14, 3] ="Canada";
            questions[14, 4] ="Mexico";
            //
            questions[15, 0] = "Which war started in 1939 and ended in 1945?";
            questions[15, 1] ="World War I";
            questions[15, 2] ="The Vietnam War";
            questions[15, 3] ="*World War II";
            questions[15, 4] ="The Falklands War";
            //
            questions[16, 0] = "Who kept a diary during the Great Fire of London in 1666?";
            questions[16, 1] ="Jeremy Clarkson";
            questions[16, 2] ="*Samuel Pepys";
            questions[16, 3] ="Dr. Seuss";
            questions[16, 4] ="Prince Charles";
            //
            questions[17, 0] = "Who was the first President of the United States of America?";
            questions[17, 1] ="George Bush";
            questions[17, 2] ="George W.Bush";
            questions[17, 3] ="*George Washington";
            questions[17, 4] ="Ronald Reagan";
            //
            questions[18, 0] = "In which country was the Battle of Hastings fought?";
            questions[18, 1] ="Scotland";
            questions[18, 2] ="Wales";
            questions[18, 3] ="*England";
            questions[18, 4] ="France";
            //
            questions[19, 0] = "Which Roman emperor built a gigantic wall across the North East of England in 122 AD?";
            questions[19, 1] ="Augustus";
            questions[19, 2] ="*Hadrian";
            questions[19, 3] ="Nero";
            questions[19, 4] ="Caesar";

        }

        public override string getQuestion(int i)
        {
            return questions[i, 0];
        }

        public override string getAnswer(int i, int j)
        {
            return questions[i, j];
        }

        //am nevoie de numarul de intrebari in cazul unei schimbari a numarului intrebarilor in cod
        public override int getQuestionNumber
        {
            get
            {
                return questions.GetLength(0);
            }

        }
    }
}
