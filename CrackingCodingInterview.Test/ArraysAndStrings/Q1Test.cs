using CrackingCodingInterview.ArraysAndStrings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingCodingInterview.Test.ArraysAndStrings
{
    [TestClass]
    public class Q1Test
    {
        [TestMethod]
        public void S1ShouldUnique()
        {
            Assert.AreEqual(true, new Q1().IsUniqueS1("abcABC"));
        }

        [TestMethod]
        public void S1ShouldNotUnique()
        {
            Assert.AreEqual(false, new Q1().IsUniqueS1("abcaBC"));
        }

        [TestMethod]
        public void S2ShouldUnique()
        {
            Assert.AreEqual(true, new Q1().IsUniqueS2("abcABC"));
        }

        [TestMethod]
        public void S2ShouldNotUnique()
        {
            Assert.AreEqual(false, new Q1().IsUniqueS2("abcaBC"));
        }

        [TestMethod]
        public void S3ShouldUnique()
        {
            Assert.AreEqual(true, new Q1().IsUniqueS3("abc"));
        }

        [TestMethod]
        public void S3ShouldNotUnique()
        {
            Assert.AreEqual(false, new Q1().IsUniqueS3("abca"));
        }

        [TestMethod]
        public void S4ShouldUnique()
        {
            Assert.AreEqual(true, new Q1().IsUniqueS4("abcABC"));
        }

        [TestMethod]
        public void S4ShouldNotUnique()
        {
            Assert.AreEqual(false, new Q1().IsUniqueS4("abcaBC"));
        }

        [TestMethod]
        public void S5ShouldUnique()
        {
            Assert.AreEqual(true, new Q1().IsUniqueS5("abcABC"));
        }

        [TestMethod]
        public void S5ShouldNotUnique()
        {
            Assert.AreEqual(false, new Q1().IsUniqueS5("abcaBC"));
        }
    }
}