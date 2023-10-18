using leetCode;

namespace test
{
    [TestClass]
    public class TwoSumTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var solution = new TwoSum();

            // Test Case 1
            int[] nums1 = { 2, 7, 11, 15 };
            int target1 = 9;
            int[] expected1 = { 0, 1 };
            var result1 = solution.getTwoSum(nums1, target1);
            CollectionAssert.AreEqual(expected1, result1);

            // Test Case 2
            int[] nums2 = { 3, 2, 4 };
            int target2 = 6;
            int[] expected2 = { 1, 2 };
            var result2 = solution.getTwoSum(nums2, target2);
            CollectionAssert.AreEqual(expected2, result2);

            // Test Case 3
            int[] nums3 = { 3, 3 };
            int target3 = 6;
            int[] expected3 = { 0, 1 };
            var result3 = solution.getTwoSum(nums3, target3);
            CollectionAssert.AreEqual(expected3, result3);

            // Additional test cases can be added as needed.
        }
    }
}