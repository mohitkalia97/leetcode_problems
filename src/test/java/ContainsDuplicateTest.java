import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.Arguments;
import org.junit.jupiter.params.provider.MethodSource;

import java.util.stream.Stream;

import static org.junit.jupiter.api.Assertions.assertEquals;

public class ContainsDuplicateTest {

    @ParameterizedTest
    @MethodSource("testCases")
    public void testSolutions(int[] nums, boolean expected){
        boolean result = ContainsDuplicate.containsDuplicate(nums);

        assertEquals(expected, result);
    }

    static Stream<Arguments> testCases(){
        return Stream.of(
                Arguments.of(new int[]{1,2,3,1}, true),
                Arguments.of(new int[]{1,2,3,4}, false),
                Arguments.of(new int[]{1,1,1,3,3,4,3,2,4,2}, true)
        );
    }
}
