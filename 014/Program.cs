long count = 0, biggestCount = 0, biggestNumber = 0;
for (long i = 2; i < 1_000_000; i++)
{
    Chain(i);
    if (count > biggestCount)
    {
        biggestCount = count;
        biggestNumber = i;
    }
    count = 0;
}
Console.WriteLine(biggestNumber);
long Chain(long number)
{
    count++;
    if (number == 1) return number;
    else if (number %2 == 0) return Chain(number / 2);
    else return Chain((number * 3)+1);
}