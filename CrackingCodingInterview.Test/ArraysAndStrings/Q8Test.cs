using CrackingCodingInterview.ArraysAndStrings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingCodingInterview.Test.ArraysAndStrings
{
    [TestClass]
    public class Q8Test
    {
        [TestMethod]
        public void S1ShouldSetZeroes()
        {
            var matrix = new int[3, 3]
            {
                { 1, 1, 1 },
                { 1, 0, 1 },
                { 1, 1, 1 },
            };
            new Q8().SetZeroesS1(matrix);

            var expected = new int[3, 3]
            {
                { 1, 0, 1 },
                { 0, 0, 0 },
                { 1, 0, 1 },
            };

            CollectionAssert.AreEqual(expected, matrix);
        }

        [TestMethod]
        public void S2ShouldSetZeroes()
        {
            var matrix = new int[3, 4]
            {
                { 0, 1, 2, 0 },
                { 3, 4, 5, 2 },
                { 1, 3, 1, 5 },
            };
            new Q8().SetZeroesS2(matrix);

            var expected = new int[3, 4]
            {
                { 0, 0, 0, 0 },
                { 0, 4, 5, 0 },
                { 0, 3, 1, 0 },
            };

            CollectionAssert.AreEqual(expected, matrix);
        }
    }
}