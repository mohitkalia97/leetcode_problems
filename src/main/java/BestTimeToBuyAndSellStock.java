import java.util.Arrays;
import java.util.OptionalInt;

public class BestTimeToBuyAndSellStock {
    public static int maxProfit(int[] prices) {
        //getMin in Integer
        int min = Arrays.stream(prices).min().getAsInt();

        for (int i = 0; i < prices.length; i++) {
            if(prices[i +1] == 0){
                return 0;
            }
        }

        return min;
    }
}
