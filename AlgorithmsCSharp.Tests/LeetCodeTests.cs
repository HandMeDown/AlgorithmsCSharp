using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsCSharp.Tests
{
    class LeetCodeTests
    {

        [Test]
        public void RectangleOverlap_ValidInput_True()
        {
            int[] rec1 = { 0, 0, 2, 2 };
            int[] rec2 = { 1, 1, 3, 3 };
            Assert.IsTrue(LeetCode.IsRectangleOverlap(rec1, rec2));
        }

        [Test]
        public void RectangleOverlap_ValidInput_False()
        {
            int[] rec1 = { 0, 0, 1, 1 };
            int[] rec2 = { 1, 0, 2, 1 };
            Assert.IsFalse(LeetCode.IsRectangleOverlap(rec1, rec2));
        }

        [Test]
        public void FizzBuzz_15_FizzBuzz()
        {
            var result = LeetCode.FizzBuzz(15);
            Assert.AreEqual(result[14].ToString(), "FizzBuzz");
        }
    }
}
