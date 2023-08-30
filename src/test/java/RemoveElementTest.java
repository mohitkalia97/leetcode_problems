import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.Arguments;
import org.junit.jupiter.params.provider.MethodSource;

import java.util.stream.Stream;

import static org.junit.jupiter.api.Assertions.assertArrayEquals;
import static org.junit.jupiter.api.Assertions.assertEquals;

public class RemoveElementTest {

    @ParameterizedTest
    @MethodSource("testCases")
    public void testSolution(int[] nums, int val, int expected){

        int output = RemoveElement.removeElement(nums, val);

        assertEquals(expected, output);
    }

    static Stream<Arguments> testCases() {
        return Stream.of(
                Arguments.of(new int[]{3,2,2,3}, 3,
                        2)
        );
    }

}
