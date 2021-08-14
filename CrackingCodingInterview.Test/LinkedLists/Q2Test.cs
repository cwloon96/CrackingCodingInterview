using CrackingCodingInterview.LinkedLists;
using CrackingCodingInterview.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingCodingInterview.Test.LinkedLists
{
    [TestClass]
    public class Q2Test
    {
        [TestMethod]
        public void S1ShouldReturnLastKthValue()
        {
            var listNode = new ListNode<int>(1, new ListNode<int>(2, new ListNode<int>(3, new ListNode<int>(4))));

            Assert.AreEqual(3, new Q2().ReturnKthToLastS1(listNode, 2));
        }

        [TestMethod]
        public void S2ShouldReturnLastKthValue()
        {
            var listNode = new ListNode<int>(1, new ListNode<int>(2, new ListNode<int>(3, new ListNode<int>(4))));

            Assert.AreEqual(3, new Q2().ReturnKthToLastS2(listNode, 2));
        }

        [TestMethod]
        public void S3ShouldReturnLastKthValue()
        {
            var listNode = new ListNode<int>(1, new ListNode<int>(2, new ListNode<int>(3, new ListNode<int>(4))));

            Assert.AreEqual(3, new Q2().ReturnKthToLastS3(listNode, 2));
        }
    }
}