using CrackingCodingInterview.ArraysAndStrings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingCodingInterview.Test.ArraysAndStrings
{
    [TestClass]
    public class Q6Test
    {
        [TestMethod]
        public void S1ShouldBeCompressed1()
        {
            Assert.AreEqual("a2b1c5a3", new Q6().StringCompressionS1("aabcccccaaa"));
        }

        [TestMethod]
        public void S1ShouldBeCompressed2()
        {
            Assert.AreEqual("a2b1c5a1", new Q6().StringCompressionS1("aabccccca"));
        }

        [TestMethod]
        public void S1ShouldNotBeCompressed1()
        {
            Assert.AreEqual("abcd", new Q6().StringCompressionS1("abcd"));
        }

        [TestMethod]
        public void S2ShouldBeCompressed1()
        {
            Assert.AreEqual("a2b1c5a3", new Q6().StringCompressionS2("aabcccccaaa"));
        }

        [TestMethod]
        public void S2ShouldBeCompressed2()
        {
            Assert.AreEqual("a2b1c5a1", new Q6().StringCompressionS2("aabccccca"));
        }

        [TestMethod]
        public void S2ShouldNotBeCompressed1()
        {
            Assert.AreEqual("abcd", new Q6().StringCompressionS2("abcd"));
        }
    }
}