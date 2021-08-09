using CrackingCodingInterview.ArraysAndStrings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingCodingInterview.Test.ArraysAndStrings
{
    [TestClass]
    public class Q9Test
    {
        [TestMethod]
        public void S1ShouldBeTrue()
        {
            Assert.AreEqual(true, new Q9().StringRotationS1("waterbottle", "erbottlewat"));
        }
    }
}