using CrackingCodingInterview.LinkedLists;
using CrackingCodingInterview.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CrackingCodingInterview.Test.LinkedLists
{
    [TestClass]
    public class Q6Test
    {
        [TestMethod]
        public void S1ShouldBePalindromeWithEvenLength()
        {
            var listNode = new ListNode<char>('a', new ListNode<char>('b', new ListNode<char>('b', new ListNode<char>('a'))));

            Assert.AreEqual(true, new Q6().IsPalindromeS1(listNode));
        }

        [TestMethod]
        public void S1ShouldBePalindromeWithOddLength()
        {
            var listNode = new ListNode<char>('a', new ListNode<char>('b', new ListNode<char>('c', new ListNode<char>('b', new ListNode<char>('a')))));

            Assert.AreEqual(true, new Q6().IsPalindromeS1(listNode));
        }

        [TestMethod]
        public void S1ShouldNotBePalindrome()
        {
            var listNode = new ListNode<char>('a', new ListNode<char>('b', new ListNode<char>('b', new ListNode<char>('a', new ListNode<char>('c')))));

            Assert.AreEqual(false, new Q6().IsPalindromeS1(listNode));
        }

        [TestMethod]
        public void S2ShouldBePalindromeWithEvenLength()
        {
            var listNode = new ListNode<char>('a', new ListNode<char>('b', new ListNode<char>('b', new ListNode<char>('a'))));

            Assert.AreEqual(true, new Q6().IsPalindromeS1(listNode));
        }

        [TestMethod]
        public void S2ShouldBePalindromeWithOddLength()
        {
            var listNode = new ListNode<char>('a', new ListNode<char>('b', new ListNode<char>('c', new ListNode<char>('b', new ListNode<char>('a')))));

            Assert.AreEqual(true, new Q6().IsPalindromeS1(listNode));
        }

        [TestMethod]
        public void S2ShouldNotBePalindrome()
        {
            var listNode = new ListNode<char>('a', new ListNode<char>('b', new ListNode<char>('b', new ListNode<char>('a', new ListNode<char>('c')))));

            Assert.AreEqual(false, new Q6().IsPalindromeS1(listNode));
        }
    }
}