using CrackingCodingInterview.LinkedLists;
using CrackingCodingInterview.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingCodingInterview.Test.LinkedLists
{
    [TestClass]
    public class Q8Test
    {
        [TestMethod]
        public void S1LoopBeginShouldBeFound()
        {
            var loopBegin = new ListNode<int>(3);
            var loopList = new ListNode<int>(4, new ListNode<int>(5, loopBegin));
            loopBegin.Next = loopList;

            var node = new ListNode<int>(1, new ListNode<int>(2, loopBegin));

            Assert.AreEqual(loopBegin, new Q8().FindLoopBeginningS1(node));
        }

        [TestMethod]
        public void S1LoopBeginShouldBeNull()
        {
            var node = new ListNode<int>(1, new ListNode<int>(2, new ListNode<int>(3, new ListNode<int>(4, new ListNode<int>(5)))));

            Assert.AreEqual(null, new Q8().FindLoopBeginningS1(node));
        }
    }
}