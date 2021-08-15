using CrackingCodingInterview.LinkedLists;
using CrackingCodingInterview.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingCodingInterview.Test.LinkedLists
{
    [TestClass]
    public class Q3Test
    {
        [TestMethod]
        public void S1ShouldRemoveNode()
        {
            var nodeToRemove = new ListNode<int>(2, new ListNode<int>(3, new ListNode<int>(4)));
            var listNode = new ListNode<int>(1, nodeToRemove);
            
            new Q3().DeleteMiddleNodeS1(nodeToRemove);

            Assert.AreEqual(1, listNode.Value);
            Assert.AreEqual(3, listNode.Next.Value);
            Assert.AreEqual(4, listNode.Next.Next.Value);
        }
    }
}