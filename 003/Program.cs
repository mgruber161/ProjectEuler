long num = 600851475143;
long result = 0;
for (long i = 1; i < num / 2; i += 2)
{
    if (num % i == 0)
    {
        result = i;
        Console.WriteLine(result);
    }
}