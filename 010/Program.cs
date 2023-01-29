EulerLib.EulerHelper eulerHelper = new EulerLib.EulerHelper();
long sum = 0;
for (int i = 1;i < 2_000_000; i++)
    if(eulerHelper.IsPrime(i))
        sum += i;
Console.WriteLine(sum);