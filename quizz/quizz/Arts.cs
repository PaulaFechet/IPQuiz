using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizz
{
    class Arts:Domain
    {
        private string[,] questions = new string[20, 5];

        public override string domainName
        {
            get
            {
                return "Arts";
            }
        }

        public override void Questions()
        {
            Console.WriteLine("Arts questions.");
            questions[0, 0] = "Which Spanish artist painted the series known as ‘Fantasy and Invention’ in the 18th century?";
            questions[0, 1] = "*Francisco Goya";
            questions[0, 2] = "Salvador Dali";
            questions[0, 3] = "Pablo Picasso";
            questions[0, 4] = "Joan Miro";
            //
            questions[1, 0] = "What nationality was painter Frida Kahlo ? ";
            questions[1, 1] = "*Mexican";
            questions[1, 2] = "Italian";
            questions[1, 3] = "Irish";
            questions[1, 4] = "Columbian";
            //
            questions[2, 0] = "Which city is traditionally said to be built on seven hills?";
            questions[2, 1] = "Paris";
            questions[2, 2] = "*Rome";
            questions[2, 3] = "New York";
            questions[2, 4] = "Bucharest";
            //
            questions[3, 0] = "Which US artist died in a car crash in August 1956, aged 44?";
            questions[3, 1] = "Pablo Picasso";
            questions[3, 2] = "*Jackson Pollock";
            questions[3, 3] = "Rembrandt van Rijn";
            questions[3, 4] = "Carl Andre";
            //
            questions[4, 0] = "In 1893, which country became the first to give women the right to vote?";
            questions[4, 1] = "Romania";
            questions[4, 2] = "*New Zealand";
            questions[4, 3] = "Italy";
            questions[4, 4] = "Germany";
            //
            questions[5, 0] = "A Russian woman was arrested in Paris in August 2009 for throwing a cup of tea at which work of art?";
            questions[5, 1] = "The Starry Night";
            questions[5, 2] = "The Kiss,";
            questions[5, 3] = "*The Mona Lisa";
            questions[5, 4] = "The Garden of Earthly Delights";
            //
            questions[6, 0] = "Which Venetian artist painted ‘The Stonemason’s Yard’?";
            questions[6, 1] = "Tiziano Vecellio";
            questions[6, 2] = "Tintoretto";
            questions[6, 3] = "Giorgione";
            questions[6, 4] = "*Giovanni Canaletto";
            //
            questions[7, 0] = "The Angel of the North’ is the work of which British sculptor?";
            questions[7, 1] = "*Antony Gormley";
            questions[7, 2] = "Thomas Banks";
            questions[7, 3] = "Anne Seymour Damer";
            questions[7, 4] = "Thomas Engleheart";
            //
            questions[8, 0] = "How many paintings make up William Hogarth’s ‘A Rake’s Progress’?";
            questions[8, 1] = "*8";
            questions[8, 2] = "10";
            questions[8, 3] = "12";
            questions[8, 4] = "15";
            //
            questions[9, 0] = "Which French sculptor died in November 1917?";
            questions[9, 1] = "*Auguste Rodin";
            questions[9, 2] = "Marie Tussaud";
            questions[9, 3] = "Jean Baptise Pigalle";
            questions[9, 4] = "Jean Arp";
            //
            questions[10, 0] = "‘The Kiss’ is an 1889 work by which French sculptor?";
            questions[10, 1] = "Jean Arp";
            questions[10, 2] = "*Auguste Rodin";
            questions[10, 3] = "Marie Tussand";
            questions[10, 4] = "Louise Bourgeois";

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
