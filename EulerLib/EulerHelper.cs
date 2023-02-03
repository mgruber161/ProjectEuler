namespace EulerLib
{
    public class EulerHelper
    {
        public static bool IsPrime(long number)
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
        public static int GCD(int a, int b) => b == 0 ? a : GCD(b, a % b);
        public static int CrossProduct(int n)
        {
            if (n == 0) return 1;
            return (n % 10) * CrossProduct(n / 10);
        }
        public static long[] GetDivisors(long n)
        {
            List<long> divisors = new List<long>();
            if (n < 1) return new long[] { };
            else
                for (long i = 1; i < n; i++)
                    if (n % i == 0)
                        divisors.Add(i);
            return divisors.ToArray();
        }

        public static int GetDivisorCount(long n)
        {
            int result = 1;
            if (n % 2 == 0)
                result++;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    result++;
                }
            }
            return result;
        }
        public static long Factorial(long number)
        {
            long result = 1;
            for (long i = number; i > 0; i--)
                result *= i;
            return result;
        }

        public static int[] GetDivisors(int n)
        {
            List<int> divisors = new List<int>();
            divisors.Add(1);
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0)
                    divisors.Add(i);
            return divisors.ToArray();
        }

        public static IEnumerable<IEnumerable<T>> GetPermutations<T>(IEnumerable<T> list, int length)
        {
            if (length == 1) return list.Select(t => new T[] { t });
            return GetPermutations(list, length - 1).SelectMany(t => list.Where(e => !t.Contains(e)), (t1, t2) => t1.Concat(new T[] { t2 }));
        }
    }
}