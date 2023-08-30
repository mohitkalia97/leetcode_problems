public class LengthOfLastWord {
    public static int lengthOfLastWord(String s) {
        String[] split = s.split(" ");
        return split[split.length-1].length();
    }
}
