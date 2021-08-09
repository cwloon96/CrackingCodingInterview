using CrackingCodingInterview.LinkedLists;
using CrackingCodingInterview.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingCodingInterview.Test.LinkedLists
{
    [TestClass]
    public class Q1Test
    {
        [TestMethod]
        public void S1ShouldRemoveDuplicates()
        {
            var listNode = new ListNode<int>(1, new ListNode<int>(2, new ListNode<int>(3, new ListNode<int>(2, new ListNode<int>(4)))));

            new Q1().RemoveDupS1(listNode);

            Assert.AreEqual(1, listNode.Value);
            Assert.AreEqual(2, listNode.Next.Value);
            Assert.AreEqual(3, listNode.Next.Next.Value);
            Assert.AreEqual(4, listNode.Next.Next.Next.Value);
        }

        [TestMethod]
        public void S2ShouldRemoveDuplicates()
        {
            var listNode = new ListNode<int>(1, new ListNode<int>(2, new ListNode<int>(3, new ListNode<int>(2, new ListNode<int>(4)))));

            new Q1().RemoveDupS2(listNode);

            Assert.AreEqual(1, listNode.Value);
            Assert.AreEqual(2, listNode.Next.Value);
            Assert.AreEqual(3, listNode.Next.Next.Value);
            Assert.AreEqual(4, listNode.Next.Next.Next.Value);
        }
    }
}