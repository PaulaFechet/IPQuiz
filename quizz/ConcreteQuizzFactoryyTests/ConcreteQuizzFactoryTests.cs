using Domainn;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using quizz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConcreteQuizzFactoryy;

namespace quizz.Tests
{
    [TestClass()]
    public class ConcreteQuizzFactoryTests
    {
        [TestMethod()]
        public void getDomainTest()
        {
            ConcreteQuizzFactory quizFactory = new ConcreteQuizzFactory();
            Domain domain = quizFactory.getDomain("chimie");
            Assert.IsNotNull(domain);
        }

        [TestMethod()]
        public void getDomainTest1()
        {
            ConcreteQuizzFactory quizFactory = new ConcreteQuizzFactory();
            Domain domain = quizFactory.getDomain("istorie");
            Assert.IsNotNull(domain);
        }
    }
}