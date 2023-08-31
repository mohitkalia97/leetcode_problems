import java.util.HashMap;
import java.util.Map;

public class RansomNote {
    public static boolean canConstruct(String ransomNote, String magazine) {
        HashMap<Character, Integer> result = new HashMap<>();
        for(char c : ransomNote.toCharArray()){
            result.put(c,result.getOrDefault(c,0)+1);
        }
        for(char c : magazine.toCharArray()){
            if(result.containsKey(c)){
                result.put(c,result.getOrDefault(c,0)-1);
            }
        }

        for(int val : result.values()){
            if(val > 0){
                return false;
            }
        }
        return true;
    }
}
