using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quizz
{
    class Chemistry : Domain
    {
        //private readonly string _domainName;
        private string[,] questions = new string[20, 5];
        public override string domainName
        {
            get
            {
                return "Chemistry";
            }
        }

        public override void Questions()
        {
            Console.WriteLine("Chemistry questions.");
            questions[0, 0] = " What is the most common isotope of hydrogen?";
            questions[0, 1] = "Deuterium";
            questions[0, 2] = "Tritum";
            questions[0, 3] = "*Protium";
            questions[0, 4] = "Hydrogen only has one isotope!";
            //
            questions[1, 0] = "You can't live without water! What is its chemical formula?";
            questions[1, 1] = "H2";
            questions[1, 2] = "*H2O";
            questions[1, 3] = "H2O2";
            questions[1, 4] = "O2";
            //
            questions[2, 0] = "Which of these elements is a nonmetal?";
            questions[2, 1] = "*Sulfur";
            questions[2, 2] = "Manganese";
            questions[2, 3] = "Aluminium";
            questions[2, 4] = "Beryllium";
            //
            questions[3, 0] = "Organic chemistry is the study of the compounds that make up living organisms. All organic molecules contain:";
            questions[3, 1] = "*Carbon and Hydrogen";
            questions[3, 2] = "Carbon Only";
            questions[3, 3] = "Carbon and Nitrogen";
            questions[3, 4] = "Carbon, Hydrogen, and Oxygen";
            //
            questions[4, 0] = "The symbol Ag stands for which element?";
            questions[4, 1] = "Magnesium";
            questions[4, 2] = "Gallium";
            questions[4, 3] = "*Silver";
            questions[4, 4] = "Gold";
            //
            questions[5, 0] = "A mole contains Avogadro's number of items. What is Avogadro's number?";
            questions[5, 1] = "6023";
            questions[5, 2] = "*6.023 x 10^23";
            questions[5, 3] = "3 x 10^8";
            questions[5, 4] = "6.02 x 10^-23";
            //
            questions[6, 0] = " What do you call an atom that has more protons than electrons?";
            questions[6, 1] = "a molecule";
            questions[6, 2] = "*a cation";
            questions[6, 3] = "an isotope";
            questions[6, 4] = "an anion";
            //
            questions[7, 0] = "Sulphur is not present in";
            questions[7, 1] = "iron pyrites";
            questions[7, 2] = "gypsum";
            questions[7, 3] = "coal";
            questions[7, 4] = "*chlorapatite";
            //
            questions[8, 0] = "All of the following are amino acids except:";
            questions[8, 1] = "Tyrosine";
            questions[8, 2] = "Tryptophan";
            questions[8, 3] = "Leucine";
            questions[8, 4] = "*Adenine";
            //
            questions[9, 0] = "In a solution of saltwater (a saline solution), salt is the:";
            questions[9, 1] = "*Solute";
            questions[9, 2] = "Solvent";
            questions[9, 3] = "Sol";
            questions[9, 4] = "Colloid";
            //
            questions[10, 0] = "Penicillin is widely used as";
            questions[10, 1] = "an insecticide";
            questions[10, 2] = "an antiseptic";
            questions[10, 3] = "a disinfectant";
            questions[10, 4] = "*an antibiotic";
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
