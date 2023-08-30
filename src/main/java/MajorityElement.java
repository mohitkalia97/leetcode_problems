import java.util.Collections;
import java.util.HashMap;
import java.util.Map;

public class MajorityElement {
    /*
    * Given an array nums of size n, return the majority element.

The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.



Example 1:

Input: nums = [3,2,3]
Output: 3
Example 2:

Input: nums = [2,2,1,1,1,2,2]
Output: 2


Constraints:

n == nums.length
1 <= n <= 5 * 104
-109 <= nums[i] <= 109*/
    public static int majorityElement(int[] nums) {
        HashMap<Integer, Integer> majorityHashmap = new HashMap<>();

        int majorityElement = 0;
        int maxCount = 0;

        for (int num : nums) {
            if (majorityHashmap.containsKey(num)) {
                majorityHashmap.put(num, majorityHashmap.get(num) +1);
            } else {
                majorityHashmap.put(num, 1);
            }
        }

        for (Map.Entry<Integer, Integer> entry : majorityHashmap.entrySet()) {
            int count = entry.getValue();
            if (count > maxCount) {
                maxCount = count;
                majorityElement = entry.getKey();
            }
        }
        return majorityElement;

    }
}
