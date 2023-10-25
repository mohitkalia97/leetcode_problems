using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCode
{
    public class BinarySearch
    {
        //[-1,0,3,5,9,12] //target = 9
        public static int Search(int[] nums, int target)
        {
            int start = 0;                        
            int end = nums.Length - 1; 

            while (start <= end)
            {
                int mid = (start + end) / 2; 

                if (nums[mid] == target) 
                {
                    return mid;
                }

                else if (nums[mid] > target) 
                {
                    start = mid + 1; 
                }
                else
                {
                    end = mid - 1; 
                }
            }
            return -1;

        }
    }
}
