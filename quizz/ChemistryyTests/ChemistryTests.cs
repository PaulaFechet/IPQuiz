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
 *               This is a UnitTest class for Chemistry class.            *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chemistryy.Tests
{
    [TestClass()]
    public class ChemistryTests
    {
        [TestMethod()]
        public void getQuestionTest()
        {
            Chemistry chemistry = new Chemistry();
            chemistry.Questions();
            Assert.AreEqual("You can't live without water! What is its chemical formula?", chemistry.getQuestion(1));
        }

        [TestMethod()]
        public void domainNameTest()
        {
            Chemistry chemistry = new Chemistry();
            Assert.AreEqual("Chemistry", chemistry.domainName);
        }

        [TestMethod()]
        public void getAnswerTest()
        {
            Chemistry chemistry = new Chemistry();
            chemistry.Questions();
            Assert.AreEqual("Carbon and Nitrogen", chemistry.getAnswer(3, 3));
        }

        [TestMethod()]
        public void getQuestionNumberTest()
        {
            Chemistry chemistry = new Chemistry();
            Assert.AreEqual(20, chemistry.getQuestionNumber);
        }

    }
}