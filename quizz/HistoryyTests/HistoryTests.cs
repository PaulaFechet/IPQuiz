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
 *               This is a UnitTest class for History class.              *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Historyy;

namespace quizz.Tests
{
    [TestClass()]
    public class HistoryTests
    {
        [TestMethod()]
        public void getQuestionTest()
        {
            History history = new History();
            history.Questions();
            Assert.AreEqual("The atomic bomb was dropped on Hiroshima in which decade?", history.getQuestion(3));
        }

        [TestMethod()]
        public void domainNameTest()
        {
            History history = new History();
            Assert.AreEqual("History", history.domainName);
        }


        [TestMethod()]
        public void getAnswerTest()
        {
            History history = new History();
            history.Questions();
            Assert.AreEqual("New York", history.getAnswer(2, 3));
        }

        [TestMethod()]
        public void getAnswerTest1()
        {
            History history = new History();
            history.Questions();
            Assert.AreEqual("Italy", history.getAnswer(4, 3));
        }

        [TestMethod()]
        public void getQuestionNumberTest()
        {
            History history = new History();
            Assert.AreEqual(20, history.getQuestionNumber);
        }
    }
}