using CrackingCodingInterview.LinkedLists;
using CrackingCodingInterview.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingCodingInterview.Test.LinkedLists
{
    [TestClass]
    public class Q5Test
    {
        [TestMethod]
        public void S1ShouldBeSumUp()
        {
            var l1 = new ListNode<int>(7, new ListNode<int>(1, new ListNode<int>(6)));
            var l2 = new ListNode<int>(5, new ListNode<int>(9, new ListNode<int>(2)));

            var result = new Q5().SumListS1(l1, l2);

            Assert.AreEqual(2, result.Value);
            Assert.AreEqual(1, result.Next.Value);
            Assert.AreEqual(9, result.Next.Next.Value);
        }

        [TestMethod]
        public void S1ShouldBeSumUp2()
        {
            var l1 = new ListNode<int>(6, new ListNode<int>(1, new ListNode<int>(6)));
            var l2 = new ListNode<int>(5, new ListNode<int>(9, new ListNode<int>(4)));

            var result = new Q5().SumListS1(l1, l2);

            Assert.AreEqual(1, result.Value);
            Assert.AreEqual(1, result.Next.Value);
            Assert.AreEqual(1, result.Next.Next.Value);
            Assert.AreEqual(1, result.Next.Next.Value);
        }

        [TestMethod]
        public void S1FollowUpShouldBeSumUp()
        {
            var l1 = new ListNode<int>(6, new ListNode<int>(1, new ListNode<int>(7)));
            var l2 = new ListNode<int>(2, new ListNode<int>(9, new ListNode<int>(5)));

            var result = new Q5().SumListFollowUpS1(l1, l2);

            Assert.AreEqual(9, result.Value);
            Assert.AreEqual(1, result.Next.Value);
            Assert.AreEqual(2, result.Next.Next.Value);
        }

        [TestMethod]
        public void S1FollowUpShouldBeSumUp2()
        {
            var l1 = new ListNode<int>(6, new ListNode<int>(1, new ListNode<int>(6)));
            var l2 = new ListNode<int>(4, new ListNode<int>(9, new ListNode<int>(5)));

            var result = new Q5().SumListFollowUpS1(l1, l2);

            Assert.AreEqual(1, result.Value);
            Assert.AreEqual(1, result.Next.Value);
            Assert.AreEqual(1, result.Next.Next.Value);
            Assert.AreEqual(1, result.Next.Next.Value);
        }
    }
}