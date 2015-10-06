using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskSorting;

namespace SortingTest
{
    [TestClass]
    public class FailTest
    {
        Sorting sorting = new Sorting();
        int[] actualArray;

        [TestMethod]
        public void TestBubbleSort()
        {
            actualArray = new int[] { 3, 5, 0 };
            int[] expectedArray = { 0, 3, 5, 6 };
            CollectionAssert.AreNotEqual(expectedArray, sorting.bubbleSort(actualArray));
        }

        [TestMethod]
        public void TestBubbleSortZero()
        {
            actualArray = new int[] { 0, 0, 0, 0 };
            int[] expectedArray = { 3, 4, 5, -7 };
            CollectionAssert.AreNotEqual(expectedArray, sorting.bubbleSort(actualArray));
        }


        [TestMethod]
        public void TestGnomeEmpty()
        {
            actualArray = new int[] { -9, 45, -3, 0, 3, 4 };
            int[] expectedArray = {};
            CollectionAssert.AreNotEqual(expectedArray, sorting.gnomeSort(actualArray));
        }

        [TestMethod]
        public void TestGnomeSortWithString()
        {
            actualArray = new int[] { 9, 9, 9, 9 };
            string[] expectedArray = {"dferge"};
            CollectionAssert.AreNotEqual(expectedArray, sorting.gnomeSort(actualArray));
        }

    }
}
