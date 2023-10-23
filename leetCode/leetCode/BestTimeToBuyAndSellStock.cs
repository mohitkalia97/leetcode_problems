using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace leetCode
{
    public class BestTimeToBuyAndSellStock
    {
        public static int MaxProfit(int[] prices)
        {
            int minPrice = prices[0];
            int maxProfit = 0;

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }
                else if ((prices[i] - minPrice) > maxProfit)
                {
                    maxProfit = prices[i] - minPrice;  
                }
            }
            return maxProfit;
        }
    }
}
