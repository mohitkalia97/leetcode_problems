import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.Arguments;
import org.junit.jupiter.params.provider.MethodSource;

import java.util.stream.Stream;

public class ValidAnagramTest {
    @ParameterizedTest
    @MethodSource("testCases")
    public void testSolution(String s, String t, boolean expected){
        boolean result = ValidAnagram.isAnagram(s, t);

        Assertions.assertEquals(expected, result);
    }

    static Stream<Arguments> testCases(){
        return Stream.of(
                Arguments.of("anagram", "nagaram", true),
                Arguments.of("rat", "car", false)
        );
    }
}
