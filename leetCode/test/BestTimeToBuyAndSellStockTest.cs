using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using leetCode;


namespace test
{
    [TestClass]
    public class BestTimeToBuyAndSellStockTest
    {
        [DataTestMethod]
        [DataRow(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
        [DataRow(new int[] { 7, 6, 4, 3, 1 }, 0)]
        public void BestTimeToBuyTest(int[] prices, int expected) {
            int result = BestTimeToBuyAndSellStock.MaxProfit(prices);

            Assert.AreEqual(expected, result);
        }
    }
}
