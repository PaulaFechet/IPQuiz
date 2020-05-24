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
 *                This class contains questions and answers about         *
 *                Chemistry domain. The correct answer for each           *
 *                question starts with "*".                               *
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

namespace Chemistryy
{
    public class Chemistry : Domain
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
            //raspunsurile corecte sunt notate cu * si vor fi ascunse de jucatori
            //ne vor ajuta la calcularea scorului
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
            //
            questions[11, 0] = "The nucleus of an atom consists of";
            questions[11, 1] = "electrons and neutrons";
            questions[11, 2] = "electrons and protons";
            questions[11, 3] = "*protons and neutrons";
            questions[11, 4] = "All of the these";
            //
            questions[12, 0] = "The number of moles of solute present in 1 kg of a solvent is called its";
            questions[12, 1] = "*molality";
            questions[12, 2] = "molarity";
            questions[12, 3] = "normality";
            questions[12, 4] = "formality";
            //
            questions[13, 0] = "The most electronegative element among the following is";
            questions[13, 1] = "sodium";
            questions[13, 2] = "bromine";
            questions[13, 3] = "*fluorine";
            questions[13, 4] = "oxygen";
            //
            questions[14, 0] = "The metal used to recover copper from a solution of copper sulphate is";
            questions[14, 1] = "Na";
            questions[14, 2] = "Ag";
            questions[14, 3] = "Hg";
            questions[14, 4] = "*Fe";
            //
            questions[15, 0] = "The metallurgical process in which a metal is obtained in a fused state is called";
            questions[15, 1] = "*smelting";
            questions[15, 2] = "roasting";
            questions[15, 3] = "calcinations";
            questions[15, 4] = "froth floatation";
            //
            questions[16, 0] = "The most commonly used bleaching agent is";
            questions[16, 1] = "alcohol";
            questions[16, 2] = "carbon dioxide";
            questions[16, 3] = "*chlorine";
            questions[16, 4] = "sodium chlorine";
            //
            questions[17, 0] = "The nucleus of a hydrogen atom consists of";
            questions[17, 1] = "*1 proton only";
            questions[17, 2] = "1 proton + 2 neutron";
            questions[17, 3] = "1 neutron only";
            questions[17, 4] = "1 electron only";
            //
            questions[18, 0] = "The nuclear particles which are assumed to hold the nucleons together are";
            questions[18, 1] = "electrons";
            questions[18, 2] = "positrons";
            questions[18, 3] = "neutrons";
            questions[18, 4] = "*mesons";
            //
            questions[19, 0] = "The metal that is used as a catalyst in the hydrogenation of oils is ";
            questions[19, 1] = "*Ni";
            questions[19, 2] = "Pb";
            questions[19, 3] = "Cu";
            questions[19, 4] = "Pt";
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
