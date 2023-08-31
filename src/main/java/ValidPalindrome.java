import com.sun.source.tree.BreakTree;

public class ValidPalindrome {
    public static boolean isPalindrome(String s) {
            String joinedString = s.replaceAll("[^a-zA-Z0-9]", "").toLowerCase();

            for (int i = 0, j = joinedString.length()-1; i < j; i++, j--) {
                if (joinedString.charAt(i) != joinedString.charAt(j)) {
                    return false;
                }
            }
            return true;
    }

}
