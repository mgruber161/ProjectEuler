import java.util.ArrayList;

public class Main {
    public static void main(String[] args)
    {
        ArrayList<Integer> result = new ArrayList<Integer>();
        for(int i = 2; i <1000001; i++)
        {
            char[] digits = String.valueOf(i).toCharArray();
            int num = 0;
            for (char digit : digits) {
                num += Math.pow(Character.getNumericValue(digit), 5);
            }
            if(num == i)
                result.add(num);
        }
        int sum = 0;
        for (int number : result){
            sum += number;
        }
        System.out.println(sum);
    }
}