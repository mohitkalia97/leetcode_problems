import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.Arguments;
import org.junit.jupiter.params.provider.MethodSource;

import java.util.stream.Stream;

import static org.junit.jupiter.api.Assertions.assertEquals;

public class LengthOfLastWordTest {
    @ParameterizedTest
    @MethodSource("testCases")
    public void testSolution(String s, int expected){
        int result = LengthOfLastWord.lengthOfLastWord(s);

        assertEquals(expected, result);
    }

    static Stream<Arguments> testCases() {
        return Stream.of(
                Arguments.of("Hello World", 5),
                Arguments.of("luffy is still joyboy", 6)
        );
    }

}
