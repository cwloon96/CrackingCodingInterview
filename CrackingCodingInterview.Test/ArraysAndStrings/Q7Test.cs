using CrackingCodingInterview.ArraysAndStrings;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingCodingInterview.Test.ArraysAndStrings
{
    [TestClass]
    public class Q7Test
    {
        [TestMethod]
        public void S1ShouldBeRotated()
        {
            var matrix = new int[4, 4]
            {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 },
                { 9, 10, 11, 12 },
                { 13, 14, 15, 16 },
            };
            new Q7().RotateMatrixS1(matrix);

            var expected = new int[4, 4]
            {
                { 13, 9, 5, 1 },
                { 14, 10, 6, 2 },
                { 15, 11, 7, 3 },
                { 16, 12, 8, 4 },
            };

            CollectionAssert.AreEqual(expected, matrix);
        }
    }
}