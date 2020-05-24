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
using Domainn;

namespace Artss
{
    /// <summary>
    /// Class with questions and answers for Arts domain
    /// </summary>
    public class Arts:Domain
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
            //raspunsurile corecte sunt notate cu * si vor fi ascunse de jucatori
            //ne vor ajuta la calcularea scorului
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
            //
            questions[11, 0] = "Which famous film star did Pop artist Andy Warhol make more portraits of than any other?";
            questions[11, 1] ="*Marilyn Monroe";
            questions[11, 2] = "Elizabeth Taylor";
            questions[11, 3] ="Audre Hepburn";
            questions[11, 4] = "Joan Crawford";
            //
            questions[12, 0] = "Graffiti comes from the Italian word graffiato, meaning what?";
            questions[12, 1] ="Spray painting";
            questions[12, 2] ="*Scratched";
            questions[12, 3] ="Vandalism";
            questions[12, 4] ="Wall painting";
            //
            questions[13, 0] = "Roy Lichtenstein was a leader of which artistic style?  ";
            questions[13, 1] ="Art Nouveau";
            questions[13, 2] ="*American Pop Art";
            questions[13, 3] ="Fauvism";
            questions[13, 4] ="Abstract art";
            //
            questions[14, 0] = "A painting sold for $450 million in 2019. What was it called?";
            questions[14, 1] ="*Salvador Mundi by Leonardo da Vinci";
            questions[14, 2] ="The Scream by Edvard Munch";
            questions[14, 3] ="Turquoise Marilyn by Andy Warhol";
            questions[14, 4] ="Vase with Fifteen Sunflowers by Vincent Van Gogh";
            //
            questions[15, 0] = "Which artist, who painted Campbell's Soup I,  declared everyone will be famous for 15 minutes? ";
            questions[15, 1] ="Bansky";
            questions[15, 2] ="Jean-Michel Baquiat";
            questions[15, 3] ="*Andy Warhol";
            questions[15, 4] ="Bob Ross";
            //
            questions[16, 0] = "With which colour is the great French painter Yves Klein often associated?";
            questions[16, 1] ="Red";
            questions[16, 2] ="Yellow";
            questions[16, 3] ="*Blue";
            questions[16, 4] ="Green";
            //
            questions[17, 0] = "Which eccentric Dutch artist is known for chopping off part of his ear?";
            questions[17, 1] ="Pablo Picasso";
            questions[17, 2] ="Roy Lichtenstein";
            questions[17, 3] ="*Vincent Van Gogh";
            questions[17, 4] = "Claude Monet";
            //
            questions[18, 0] = "The art critic Louis Leroy coined the term Impressionism from a painting titled Impression, soleil levant. But which artist created it?";
            questions[18, 1] ="*Claude Monet";
            questions[18, 2] = "Pablo Picasso";
            questions[18, 3] = "Roy Lichtenstein";
            questions[18, 4] = "Vincent Van Gogh";
            //
            questions[19, 0] = "In 2011, which artist covered the floor of Tate Modern’s vast Turbine Hall in 100m handmade porcelain sunflower seeds?";
            questions[19, 1] ="*Ai Weiwei";
            questions[19, 2] = "Pablo Picasso";
            questions[19, 3] = "Roy Lichtenstein";
            questions[19, 4] = "Vincent Van Gogh";


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
