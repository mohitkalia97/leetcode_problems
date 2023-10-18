using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetCode;

namespace test
{
    [TestClass]
    public class InvertBinaryTreeTests
    {
        private readonly InvertBinaryTree _InvertBinaryTree = new InvertBinaryTree();

        [TestMethod]
        [DataRow(new int[] { 4, 2, 7, 1, 3, 6, 9 }, new int[] { 4, 7, 2, 9, 6, 3, 1 })]
        [DataRow(new int[] { 2, 1, 3 }, new int[] { 2, 3, 1 })]
        [DataRow(new int[] { }, new int[] { })]
        public void TestInvertBinaryTree(int?[] input, int?[] expectedOutput)
        {
            
        }

    }
}
