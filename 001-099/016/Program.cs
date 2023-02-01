using System.Numerics;
ulong sum = 0;
foreach (var item in BigInteger.Pow(2, 1000).ToString())
    sum += (ulong)item - '0';
Console.WriteLine(sum);