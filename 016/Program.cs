using System.Numerics;
ulong sum = 0;
foreach (var item in BigInteger.Pow(2, 1000).ToString())
    sum += (ulong)Char.GetNumericValue(item);
Console.WriteLine(sum);