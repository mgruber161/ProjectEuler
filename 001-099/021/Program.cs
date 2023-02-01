int sum = 0;
for (int i = 1; i < 10000; i++)
{
    var divisorSum = EulerLib.EulerHelper.GetDivisors(i).Sum();
    if (i == EulerLib.EulerHelper.GetDivisors(divisorSum).Sum() && i != divisorSum)
        sum += i;
}
Console.WriteLine(sum);