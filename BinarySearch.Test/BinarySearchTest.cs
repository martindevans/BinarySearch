﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BinarySearch.Test
{
    [TestClass]
    public class BinarySearchTest
    {
        [TestMethod]
        public void BinarySearch_FindsSingleItem_FromSingleItem()
        {
            int[] arr = { 17 };

            int? result = BinarySearch.Find(0, arr.Length - 1, i => arr[0].CompareTo(arr[i]));

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void BinarySearch_FindsNoItem_FromNoItems()
        {
            int[] arr = { };

            int? result = BinarySearch.Find(0, arr.Length - 1, i => arr[0].CompareTo(arr[i]));

            Assert.IsFalse(result.HasValue);
        }

        [TestMethod]
        public void BinarySearch_FindsCorrectItem_AboveMidPoint_FromMultipleItems()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int? result = BinarySearch.Find(0, arr.Length - 1, i => arr[7].CompareTo(arr[i]));

            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void BinarySearch_FindsCorrectItem_BelowMidPoint_FromMultipleItems()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int? result = BinarySearch.Find(0, arr.Length - 1, i => arr[2].CompareTo(arr[i]));

            Assert.AreEqual(2, result);
        }
    }
}