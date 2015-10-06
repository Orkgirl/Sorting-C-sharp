using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskSorting;
using Selenium;

namespace SortingTest
{
    [TestClass]
    public class Tests
    {
        Sorting sorting = new Sorting();
        int[] actualArray;

        [TestMethod]
        public void TestBubbleSort()
        {
            actualArray = new int[]{ 3, 5, 0 };
            int[] expectedArray = { 0, 3, 5 };
            CollectionAssert.AreEqual(expectedArray, sorting.bubbleSort(actualArray));
        }

        [TestMethod]
        public void TestBubbleSortSame()
        {
            actualArray = new int[] { 3 ,3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3};
            int[] expectedArray = { 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3, 3 };
            CollectionAssert.AreEqual(expectedArray, sorting.bubbleSort(actualArray));
        }

        [TestMethod]
        public void TestBubbleSortAlreadySorted()
        {
            actualArray = new int[] {0, 1, 2, 8, 45};
            int[] expectedArray = { 0, 1, 2, 8, 45 };
            CollectionAssert.AreEqual(expectedArray, sorting.bubbleSort(actualArray));
        }


        [TestMethod]
        public void TestGnomeSort()
        {
            actualArray = new int[] {-9, 45, -3, 0 , 3, 4};
            int[] expectedArray = {-9, -3, 0, 3, 4, 45};
            CollectionAssert.AreEqual(expectedArray, sorting.gnomeSort(actualArray));
        }

        [TestMethod]
        public void TestGnomeSortSame()
        {
            actualArray = new int[] { 9, 9, 9, 9};
            int[] expectedArray = { 9, 9, 9, 9 };
            CollectionAssert.AreEqual(expectedArray, sorting.gnomeSort(actualArray));
        }

        [TestMethod]
        public void TestGnomeSortSameAlreadySorted()
        {
            actualArray = new int[] { -10, 0, 9, 19 };
            int[] expectedArray = { -10, 0, 9, 19 };
            CollectionAssert.AreEqual(expectedArray, sorting.gnomeSort(actualArray));
        }


    }
}