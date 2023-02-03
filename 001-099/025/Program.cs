using System.Numerics;

BigInteger bigInteger1 = 1;
BigInteger bigInteger2 = 1;
ulong index = 2;

while (bigInteger1.ToString().Length < 1000 && bigInteger2.ToString().Length < 1000)
{
    bigInteger1 += bigInteger2;
    bigInteger2 += bigInteger1;
    index += 2;
}

Console.WriteLine($"{bigInteger1}\n\n{bigInteger2}\n\n{index}");
