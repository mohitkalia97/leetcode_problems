import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.Arguments;
import org.junit.jupiter.params.provider.MethodSource;

import java.util.stream.Stream;

import static org.junit.jupiter.api.Assertions.assertArrayEquals;

public class TwoSumTest {

    @ParameterizedTest
    @MethodSource("testCases")
    public void testSolution(int[] nums, int target, int[] expected){
        int[] result = TwoSum.twoSum(nums, target);

        assertArrayEquals(expected, result);
    }

    static Stream<Arguments> testCases(){
        return Stream.of(
                Arguments.of(new int[]{2,7,11,15}, 9,
                        new int[]{0,1})
        );
    }
}
