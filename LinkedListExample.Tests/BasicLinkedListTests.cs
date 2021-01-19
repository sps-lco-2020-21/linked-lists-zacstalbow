﻿using System;
using LinkedListExample.Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinkedListExample.Tests
{
    [TestClass]
    public class BasicLinkedListTests
    {
        [TestMethod]
        public void TestCount()
        {
            var ill = new IntegerLinkedList(5);
            ill.Append(7);
            ill.Append(9);
            Assert.AreEqual(3, ill.Count);
        }

        [TestMethod]
        public void TestSum()
        {
            var ill = new IntegerLinkedList(5);
            ill.Append(7);
            ill.Append(9);
            Assert.AreEqual(21, ill.Sum);
        }

        [TestMethod]
        public void TestToStringExplicit()
        {
            var ill = new IntegerLinkedList(5);
            ill.Append(7);
            ill.Append(9);
            Assert.AreEqual("{5, 7, 9}", ill.ToString());
        }

    }
}
