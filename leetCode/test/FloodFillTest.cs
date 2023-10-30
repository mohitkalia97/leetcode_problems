using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode;

namespace test
{
    [TestClass]
    public class FloodFillTest
    {
        [DataTestMethod]
        [DynamicData(nameof(GetTestData), DynamicDataSourceType.Method)]
        public void testFloodFill(int[][] image, int sr, int sc, int color, int[][] ex) {

            int[][] res = FloodFill.doFloodFill(image, sr, sc, color);

            Assert.AreEqual(res, ex);
        }

        public IEnumerable<object[]> GetTestData()
        {
            yield return new object[]
            {
                new int[,]{ { 1, 1, 1 }, { 1, 1, 0 }, { 1, 0, 1 } }, 1, 1, 2, new int[,]{ {0, 0, 0} , {0, 0, 0}, {0, 0, 0} }             
            };

            yield return new object[]
           {
                new int[,]{ { 0, 0, 0 }, { 0, 0, 0 } }, 0, 0, 0, new int[,]{ {0, 0, 0} , {0, 0, 0} }
           };
        }
    }
}
