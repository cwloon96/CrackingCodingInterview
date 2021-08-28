using CrackingCodingInterview.LinkedLists;
using CrackingCodingInterview.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingCodingInterview.Test.LinkedLists
{
    [TestClass]
    public class Q7Test
    {
        [TestMethod]
        public void S1IntersectionShouldBeFound()
        {
            var intersect = new ListNode<int>(7, new ListNode<int>(2, new ListNode<int>(1)));
            var l1 = new ListNode<int>(3, new ListNode<int>(1, new ListNode<int>(5, new ListNode<int>(9, intersect))));
            var l2 = new ListNode<int>(4, new ListNode<int>(6, intersect));

            Assert.AreEqual(intersect, new Q7().FindIntersectionS1(l1, l2));
        }

        [TestMethod]
        public void S1IntersectionShouldBeNull()
        {
            var l1 = new ListNode<int>(3, new ListNode<int>(1, new ListNode<int>(5, new ListNode<int>(9, new ListNode<int>(7, new ListNode<int>(2, new ListNode<int>(1)))))));
            var l2 = new ListNode<int>(4, new ListNode<int>(6, new ListNode<int>(7, new ListNode<int>(2, new ListNode<int>(1)))));

            Assert.AreEqual(null, new Q7().FindIntersectionS1(l1, l2));
        }
    }
}