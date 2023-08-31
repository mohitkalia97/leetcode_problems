import org.junit.jupiter.params.ParameterizedTest;
import org.junit.jupiter.params.provider.Arguments;
import org.junit.jupiter.params.provider.MethodSource;

import java.util.stream.Stream;

import static org.junit.jupiter.api.Assertions.assertEquals;

public class RansomNoteTest {
    @ParameterizedTest
    @MethodSource("testCases")
    public void testSolution(String ransomNote, String magazine, boolean expected){
        boolean result = RansomNote.canConstruct(ransomNote, magazine);

        assertEquals(expected, result);
    }

    static Stream<Arguments> testCases(){
        return Stream.of(
                Arguments.of("a", "b", false),
                Arguments.of("aa", "ab", false),
                Arguments.of("aa", "aab", true)
        );
    }
}
