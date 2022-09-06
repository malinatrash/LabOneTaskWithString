using Microsoft.VisualStudio.TestTools.UnitTesting;
using LabOneTaskString;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabOneTaskString.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        public void IsSentenseDoesNotContainSpaces()
        {
            var sentense = "abcdefg";

            var reversedSentense = Logic.Reverse(sentense);

            Assert.AreEqual("abcdefg", reversedSentense);
        }

        [TestMethod()]
        public void IsSentenseContainSpaces()
        {
            var sentense = "abc def";

            var reversedSentense = Logic.Reverse(sentense);

            Assert.AreEqual("def abc", reversedSentense);
        }

        [TestMethod()]
        public void IsSentenseIsRandomString()
        {
            var sentense = "i hate mac";

            var reversedSentense = Logic.Reverse(sentense);

            Assert.AreEqual("mac hate i ", reversedSentense);
        }
    }
}