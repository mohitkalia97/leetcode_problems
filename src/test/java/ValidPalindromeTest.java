import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.Arguments;
import org.junit.jupiter.params.provider.MethodSource;

import java.util.stream.Stream;

import static org.junit.jupiter.api.Assertions.assertEquals;
import static org.junit.jupiter.api.Assertions.assertTrue;

public class ValidPalindromeTest {
    @ParameterizedTest
    @MethodSource("testCases")
    public void testValidPalindrome(String s, boolean expected){

        boolean result = ValidPalindrome.isPalindrome(s);

        assertEquals(expected, result);
    }

    static Stream<Arguments> testCases(){
        return Stream.of(
                Arguments.of(" ", true),
                Arguments.of("race a car", false),
                Arguments.of("A man, a plan, a canal: Panama", true)
        );
    }
}
