using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using leetCode;

namespace test
{
    [TestClass]
    public class InvertBinaryTreeTests
    {
        [DataTestMethod]
        [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
        public void TestInvertBinaryTree(TreeNode root, TreeNode expected)
        {
            TreeNode result = TreeNode.InvertTree(root);

            AssertTreesAreEqual(expected, result);
        }

        public static IEnumerable<object[]> GetTestData()
        {
            yield return new object[]
            {
                // [4,2,7,1,3,6,9] => [4,7,2,9,6,3,1]
                new TreeNode(4, new TreeNode(2, new TreeNode(7, new TreeNode(1), new TreeNode(3)), new TreeNode(6, new TreeNode(9)))),
                new TreeNode(4, new TreeNode(7, new TreeNode(9), new TreeNode(6)), new TreeNode(2, new TreeNode(3), new TreeNode(1)))
            };

            yield return new object[]
            {
            new TreeNode(2, new TreeNode(1), new TreeNode(3)),
            new TreeNode(2, new TreeNode(3), new TreeNode(1))
            };
            yield return new object[] { null, null };
            }

        private void AssertTreesAreEqual(TreeNode expected, TreeNode actual)
        {
            if (expected == null && actual == null) return;

            Assert.IsNotNull(expected);
            Assert.IsNotNull(actual);

            Assert.AreEqual(expected.val, actual.val);

            AssertTreesAreEqual(expected.left, actual.left);
            AssertTreesAreEqual(expected.right, actual.right);
        }





    }
}
