using CrackingCodingInterview.ArraysAndStrings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingCodingInterview.Test.ArraysAndStrings
{
    [TestClass]
    public class Q4Test
    {
        [TestMethod]
        public void S1ShouldBePermutedPalindrome()
        {
            Assert.AreEqual(true, new Q4().PalindromePermutationS1("tact coa"));
        }

        [TestMethod]
        public void S1ShouldNotBePermutedPalindrome()
        {
            Assert.AreEqual(false, new Q4().PalindromePermutationS1("tact coaa"));
        }

        [TestMethod]
        public void S2ShouldBePermutedPalindrome()
        {
            Assert.AreEqual(true, new Q4().PalindromePermutationS2("tact coa"));
        }

        [TestMethod]
        public void S2ShouldNotBePermutedPalindrome()
        {
            Assert.AreEqual(false, new Q4().PalindromePermutationS2("tact coaa"));
        }

        [TestMethod]
        public void S3ShouldBePermutedPalindrome()
        {
            Assert.AreEqual(true, new Q4().PalindromePermutationS3("tact coa"));
        }

        [TestMethod]
        public void S3ShouldNotBePermutedPalindrome()
        {
            Assert.AreEqual(false, new Q4().PalindromePermutationS3("tact coaa"));
        }
    }
}