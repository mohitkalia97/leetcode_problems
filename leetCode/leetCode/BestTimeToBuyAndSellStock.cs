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
            // find index of smallest int
            // beginn loop starting at smallest index

            int temp = 0;
            int result = 0;
            for (int i = 0; i < prices.Length-1; i++)
            {
                for (global::System.Int32 j = i+1; j < prices.Length; j++)
                {
                    result = prices[j] - prices[i];
                    if(result > temp)
                    {
                        temp = result;
                    }
                }
            }
            return temp;
            
        }
    }
}
