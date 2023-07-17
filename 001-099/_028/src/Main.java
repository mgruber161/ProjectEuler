public class Main {
    public static void main(String[] args) {
        int sum = 1;
        int seperator = 2;
        int addCounter = 0;
        for (int i = 3; seperator < 1001; i+=seperator){
            sum+=i;
            addCounter++;
            if(addCounter % 4 == 0)
                seperator += 2;
        }
        System.out.println(sum);
    }
}