using System.Numerics;
BigInteger big = FactorialNumber(100);
long sum = 0;
foreach (var character in big.ToString())
	sum += character - '0';
Console.WriteLine(sum);
BigInteger FactorialNumber(int v)
{
	BigInteger res = new BigInteger(1);
	for (int i = 1; i < v; i++)
		res *= i;
	return res;
}