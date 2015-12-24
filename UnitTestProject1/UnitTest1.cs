using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeWars_StringCalculator.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LessThan10()
        {
            Assert.AreEqual(5, Kata.AddStrings("2, 3"));
        }

        [TestMethod]
        public void Over50()
        {
            Assert.AreEqual(60, Kata.AddStrings("20, 20, 20"));
        }
    }
}