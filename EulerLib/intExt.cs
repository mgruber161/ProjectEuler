using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerLib
{
    public static class intExt
    {
        public static bool IsAbundant(this int i) => i.DivisorSum() > i;

        public static int DivisorSum(this int n)
        {
            int sum = 1;
            for (int i = 2; i <= n / 2; i++)
                if (n % i == 0)
                    sum += i;
            return sum;
        }
    }
}
