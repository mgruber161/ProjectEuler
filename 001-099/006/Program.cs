int sum = 0, squaresum = 0;
for (int i = 1; i < 101; i++)
{
    sum += i;
    squaresum += (int)Math.Pow(i, 2);
}
Console.WriteLine($"Difference: {Math.Pow(sum, 2) - squaresum}");