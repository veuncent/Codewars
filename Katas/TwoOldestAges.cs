﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Katas
{
    public class LargestTwo
    {
        public static int[] TwoOldestAges(int[] ages)
        {
            return ages.OrderByDescending(a => a).Take(2).OrderBy(a => a).ToArray();
        }
    }

    [TestFixture]
    public class Tests
    {

        [Test]
        public void Test1()
        {
            int[] result = LargestTwo.TwoOldestAges(new[] { 1, 2, 10, 8 });
            Assert.AreEqual(new int[] { 8, 10 }, result);
        }

        [Test]
        public void Test2()
        {
            int[] result = LargestTwo.TwoOldestAges(new[] { 1, 5, 87, 45, 8, 8 });
            Assert.AreEqual(new int[] { 45, 87 }, result);
        }

        [Test]
        public void Test3()
        {
            int[] result = LargestTwo.TwoOldestAges(new[] { 6, 5, 83, 5, 3, 18 });
            Assert.AreEqual(new int[] { 18, 83 }, result);
        }

        [Test]
        public void Test4()
        {
            int[] result = LargestTwo.TwoOldestAges(new[] { 6, 5, 83, 83 });
            Assert.AreEqual(new int[] { 83, 83 }, result);
        }
    }
}
