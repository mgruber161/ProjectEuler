import java.math.BigInteger;
import java.util.ArrayList;

public class Main {
    public static void main(String[] args) {
        ArrayList<BigInteger> allNumbers = new ArrayList<BigInteger>();

        for(int i = 2; i <= 100; i++){
            for(int j = 2; j <= 100; j++){
                allNumbers.add(new BigInteger(String.valueOf(i)).pow(j));
            }
        }
        int result = allNumbers.stream().distinct().toList().size();
        System.out.println(result);
    }
}