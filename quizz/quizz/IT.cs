using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizz

{
    class IT : Domain
    {
        //private readonly string _domainName;
        private string[,] questions = new string[20, 5];
        public override string domainName
        {
            get
            {
                return "IT";
            }
        }

        public override void Questions()
        {
            Console.WriteLine("IT questions.");
            questions[0, 0] = "Which one is te first search engine in internet?";
            questions[0, 1] = "Google";
            questions[0, 2] = "*Archie";
            questions[0, 3] = "Altavista";
            questions[0, 4] = "WAIS";
            //
            questions[1, 0] = "Number of bit used by the IPv6 address is:";
            questions[1, 1] = "32 bit";
            questions[1, 2] = "62 bit";
            questions[1, 3] = "*128 bit";
            questions[1, 4] = "256 bit";
            //
            questions[2, 0] = "Which one is the frst web browser invented in 1990";
            questions[2, 1] = "*Nexus";
            questions[2, 2] = "Internet Explorer";
            questions[2, 3] = "Mozilla";
            questions[2, 4] = "Mosaic";
            //
            questions[3, 0] = "Which of the following programming languages is used to create programs like applets?";
            questions[3, 1] = "*Java";
            questions[3, 2] = "C";
            questions[3, 3] = "COBOL";
            questions[3, 4] = "BASIC";
            //
            questions[4, 0] = "First computer virus is known as:";
            questions[4, 1] = "Rabbit";
            questions[4, 2] = "*Creeper Virus";
            questions[4, 3] = "Elk Cloner";
            questions[4, 4] = "SCA Virus";
            //
            questions[5, 0] = "Which one programming language is exclusively used for artificial intelligence";
            questions[5, 1] = "C";
            questions[5, 2] = "*Prolog";
            questions[5, 3] = "Java";
            questions[5, 4] = "J2EE";
            //
            questions[6, 0] = "Firewall in computer is used for:";
            questions[6, 1] = "*Security";
            questions[6, 2] = "Data Transmission";
            questions[6, 3] = "Authentication";
            questions[6, 4] = "Monitoring";
            //
            questions[7, 0] = "A dual layer Blue-ray Disc can store data upto";
            questions[7, 1] = "20GB";
            questions[7, 2] = "35GB";
            questions[7, 3] = "15GB";
            questions[7, 4] = "*50GB";
            //
            questions[8, 0] = "Which of the following is not an operating system?";
            questions[8, 1] = "DOS";
            questions[8, 2] = "Mac";
            questions[8, 3] = "Linus";
            questions[8, 4] = "*C";
            //
            questions[9, 0] = "Which of the following is not a database management software?";
            questions[9, 1] = "MySQL";
            questions[9, 2] = "Oracle";
            questions[9, 3] = "Sybase";
            questions[9, 4] = "*COBOL";
            //
            questions[10, 0] = "Number of layers in the OSI(Open Systems Inerconnection) Model";
            questions[10, 1] = "11";
            questions[10, 2] = "9";
            questions[10, 3] = "4";
            questions[10, 4] = "*7";
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
