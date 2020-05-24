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
 *               This is a UnitTest class for IT class.                   *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ITT.Tests
{
    [TestClass()]
    public class ITTests
    {
        [TestMethod()]
        public void getQuestionTest()
        {
            IT it = new IT();
            it.Questions();
            Assert.AreEqual("Firewall in computer is used for:", it.getQuestion(6));
        }

        [TestMethod()]
        public void domainNameTest()
        {
            IT it = new IT();
            Assert.AreEqual("IT", it.domainName);
        }

        [TestMethod()]
        public void getAnswerTest()
        {
            IT it = new IT();
            it.Questions();
            Assert.AreEqual("Mozilla", it.getAnswer(2, 3));
        }

        [TestMethod()]
        public void getQuestionNumberTest()
        {
            IT it = new IT();
            Assert.AreEqual(20, it.getQuestionNumber);
        }

    }
}