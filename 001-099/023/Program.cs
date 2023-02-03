using EulerLib;
int sum = 0;
List<int> abundantNumbers = new List<int>();
for(int i = 11;i < 28120; i++)
    if(i.IsAbundant())
        abundantNumbers.Add(i);

for (int i = 1;i < 20162; i++)
{
    if(i % 2 == 0 || i > 946)
    {
        List<int> possibleParts = abundantNumbers.Where(p => p < i).ToList();
        bool isSummable = false;
        for (int j = 0; j < possibleParts.Count() && !isSummable; j++)
            for (int k = 0; k < possibleParts.Count() && !isSummable; k++)
                if (possibleParts[j] + possibleParts[k] == i)
                    isSummable = true;
        if (!isSummable)
            sum += i;
    }
    else
        sum += i;
}
Console.WriteLine(sum);