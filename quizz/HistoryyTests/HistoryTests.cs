using Microsoft.VisualStudio.TestTools.UnitTesting;
using Historyy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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