import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.Arguments;
import org.junit.jupiter.params.provider.MethodSource;

import java.util.stream.Stream;

import static org.junit.jupiter.api.Assertions.assertEquals;

public class MajorityElementTest {
    @ParameterizedTest
    @MethodSource("testCases")
    public void testSolution(int[] nums, int expected){

        int result = MajorityElement.majorityElement(nums);

        assertEquals(expected, result);
    }


    static Stream<Arguments> testCases(){
        return Stream.of(
                Arguments.of(new int[]{3,2,3}, 3)
        );
    }
}
