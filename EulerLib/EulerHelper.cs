namespace EulerLib
{
    public class EulerHelper
    {
        public bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            var boundary = (int)Math.Floor(Math.Sqrt(number));
            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;
            return true;
        }
        public int GCD(int a, int b) => b == 0 ? a : GCD(b, a % b);
        public int CrossProduct(int n)
        {
            if (n == 0) return 1;
            return (n % 10) * CrossProduct(n / 10);
        }
    }
}