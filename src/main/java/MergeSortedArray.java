import java.util.Arrays;

public class MergeSortedArray {
        public static int[] merge(int[] nums1, int m, int[] nums2, int n) {
            for(int j = 0, i = m; j < n; j++ ){
                nums1[i] = nums2[j];
                i++;
            }
            Arrays.sort(nums1);

            return nums1;
        }
}

