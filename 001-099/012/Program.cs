long triangleNumber = 0;
for (int i = 1; i < int.MaxValue; i++)
{
    triangleNumber += i;
    if (EulerLib.EulerHelper.GetDivisorCount(triangleNumber) > 500)
    {
        Console.WriteLine(triangleNumber);
    }
}