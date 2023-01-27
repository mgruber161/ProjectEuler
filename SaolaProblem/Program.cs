int count = 0;
for (int a = 2; a < 16; a++)
	for (int b = 2; b < 16; b++)
		for (int c = 2; c < 16; c++)
            if(30 % a == 0 && 30 % b == 0 && 30 % c == 0)
                if(IsPrime(GCD(a,b)) && IsPrime(GCD(b, c)))
                {
                    count++;
                    Console.WriteLine($"#{count}: a = {a}, b = {b}, c = {c}");
                }

int GCD(int a, int b) => b == 0 ? a : GCD(b, a % b);

bool IsPrime(int number)
{
    if (number <= 1) return false;
    if (number == 2) return true;
    if (number % 2 == 0) return false;

    var boundary = (int)Math.Floor(Math.Sqrt(number));

    for (int i = 3; i <= boundary; i += 2)
        if (number % i == 0)
            return false;

    return true;
}