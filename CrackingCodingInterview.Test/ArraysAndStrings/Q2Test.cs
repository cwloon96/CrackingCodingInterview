using CrackingCodingInterview.ArraysAndStrings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingCodingInterview.Test.ArraysAndStrings
{
    [TestClass]
    public class Q2Test
    {
        [TestMethod]
        public void S1ShouldBePermuted()
        {
            Assert.AreEqual(true, new Q2().CheckPermutationS1("abc ", "c ba"));
        }

        [TestMethod]
        public void S1ShouldBeNotPermuted()
        {
            Assert.AreEqual(false, new Q2().CheckPermutationS1("abc", "abz"));
        }

        [TestMethod]
        public void S2ShouldBePermuted()
        {
            Assert.AreEqual(true, new Q2().CheckPermutationS2("abc ", "c ba"));
        }

        [TestMethod]
        public void S2ShouldBeNotPermuted()
        {
            Assert.AreEqual(false, new Q2().CheckPermutationS2("abc", "abz"));
        }
    }
}