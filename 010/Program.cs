long sum = 0;
for (int i = 1;i < 2_000_000; i++)
    if(EulerLib.EulerHelper.IsPrime(i))
        sum += i;
Console.WriteLine(sum);