for (int i = 2500; i < int.MaxValue; i++)
    if(EvenlyDivisable(i))
        Console.WriteLine(i);

bool EvenlyDivisable(int i)
{
    for (int j = 1; j < 21; j++)
        if(i % j != 0)
            return false;
    return true;
}