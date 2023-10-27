List<int> results = new List<int> { };

for (int i = 1_000; i < 100_000; i++)
    if (IsPandigitalProduct(i)) results.Add(i);

Console.WriteLine(results.Distinct().Sum());

bool IsPandigitalProduct(int i)
{

    foreach (var divisor in EulerLib.EulerHelper.GetDivisors(((long)i)))
    {
        var characters = (i / divisor).ToString() + i.ToString() + divisor.ToString();
        if (characters.Length == 9)
            if (EulerLib.EulerHelper.IsPandigital(int.Parse(characters))) return true;
    }
    return false;
}
