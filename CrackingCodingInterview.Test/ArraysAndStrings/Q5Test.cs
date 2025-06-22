using CrackingCodingInterview.ArraysAndStrings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingCodingInterview.Test.ArraysAndStrings
{
    [TestClass]
    public class Q5Test
    {
        [TestMethod]
        public void S1ShouldBeTrueWithOneModification()
        {
            Assert.AreEqual(true, new Q5().OneAwayS1("pale", "kale"));
        }

        [TestMethod]
        public void S1ShouldBeTrueWithOneDeletion()
        {
            Assert.AreEqual(true, new Q5().OneAwayS1("pale", "ple"));
        }

        [TestMethod]
        public void S1ShouldBeTrueWithOneInsertion()
        {
            Assert.AreEqual(true, new Q5().OneAwayS1("pale", "palle"));
        }

        [TestMethod]
        public void S1ShouldBeFalseWithTwoModification()
        {
            Assert.AreEqual(false, new Q5().OneAwayS1("pale", "bake"));
        }

        [TestMethod]
        public void S1ShouldBeFalseWithTwoDeletion()
        {
            Assert.AreEqual(false, new Q5().OneAwayS1("pale", "pe"));
        }

        [TestMethod]
        public void S1ShouldBeFalseWithTwoInsertion()
        {
            Assert.AreEqual(false, new Q5().OneAwayS1("pe", "pale"));
        }

        [TestMethod]
        public void S1ShouldBeFalseWithDeletionAndModification()
        {
            Assert.AreEqual(false, new Q5().OneAwayS1("pale", "lkale"));
        }
    }
}