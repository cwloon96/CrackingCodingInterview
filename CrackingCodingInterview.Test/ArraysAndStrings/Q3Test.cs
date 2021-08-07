using CrackingCodingInterview.ArraysAndStrings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingCodingInterview.Test.ArraysAndStrings
{
    [TestClass]
    public class Q3Test
    {
        [TestMethod]
        public void S1ShouldBeUrlified()
        {
            string s = "Mr John Smith      ";
            var arr = s.ToCharArray();
            new Q3().UrlifyS1(arr, 13);

            string expected = "Mr%20John%20Smith\0 ";
            Assert.AreEqual(expected, new string(arr));
        }
    }
}