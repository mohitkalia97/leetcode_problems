using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode;

namespace test
{
    [TestClass]
    public class BinarySearchTest
    {
        [DataTestMethod]
        [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
        public void testSearch(int[] nums, int target, int ex)
        {
            int res = BinarySearch.Search(nums, target);
            Assert.AreEqual(ex, res);   
        }

        public static IEnumerable<object[]> GetTestData()
        {
            yield return new object[] {
                new int[] {-1,0,3,5,9,12}, 9, 4
            };

            yield return new object[] {
                new int[]{-1,0,3,5,9,12}, 2, -1
            };
            yield return new object[] {
                new int[]{-1,0,3,5,9,12}, 2, -1
            };
        }
    }
}
