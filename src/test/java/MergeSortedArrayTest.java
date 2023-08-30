import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.Arguments;
import org.junit.jupiter.params.provider.MethodSource;

import java.util.stream.Stream;

import static org.junit.jupiter.api.Assertions.assertArrayEquals;
import static org.junit.jupiter.api.Assertions.assertEquals;


public class MergeSortedArrayTest {

    @ParameterizedTest
    @MethodSource("testCases")
    public void testSolution(int[] nums1, int m, int[] nums2, int n, int[] expected){

        int[] output = MergeSortedArray.merge(nums1, m, nums2, n);

        assertArrayEquals(expected, output);
    }

    static Stream<Arguments> testCases() {
        return Stream.of(
                Arguments.of(new int[]{1,2,3,0,0,0}, 3, new int[]{2,5,6}, 3,
                        new int[]{1,2,2,3,5,6})
        );
    }


}
