using CrackingCodingInterview.LinkedLists;
using CrackingCodingInterview.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingCodingInterview.Test.LinkedLists
{
    [TestClass]
    public class Q4Test
    {
        [TestMethod]
        public void S1ShouldBePartitioned()
        {
            var listNode = new ListNode<int>(6, new ListNode<int>(5, new ListNode<int>(1, new ListNode<int>(2, new ListNode<int>(4, new ListNode<int>(7))))));
            
            var result = new Q4().PartitionS1(listNode, 5);

            Assert.AreEqual(1, result.Value);
            Assert.AreEqual(2, result.Next.Value);
            Assert.AreEqual(4, result.Next.Next.Value);
            Assert.AreEqual(6, result.Next.Next.Next.Value);
            Assert.AreEqual(5, result.Next.Next.Next.Next.Value);
            Assert.AreEqual(7, result.Next.Next.Next.Next.Next.Value);
        }

        [TestMethod]
        public void S2ShouldBePartitioned()
        {
            var listNode = new ListNode<int>(6, new ListNode<int>(5, new ListNode<int>(1, new ListNode<int>(2, new ListNode<int>(4, new ListNode<int>(7, new ListNode<int>(3)))))));

            var result = new Q4().PartitionS2(listNode, 5);

            Assert.AreEqual(3, result.Value);
            Assert.AreEqual(4, result.Next.Value);
            Assert.AreEqual(2, result.Next.Next.Value);
            Assert.AreEqual(1, result.Next.Next.Next.Value);
            Assert.AreEqual(6, result.Next.Next.Next.Next.Value);
            Assert.AreEqual(5, result.Next.Next.Next.Next.Next.Value);
            Assert.AreEqual(7, result.Next.Next.Next.Next.Next.Next.Value);
        }
    }
}