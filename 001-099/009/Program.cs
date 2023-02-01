for (int a = 0; a < 1000; a++)
    for (int b = 0;b < 1000; b++)
        for (int c = 0;c < 1000; c++)
            if(a + b + c == 1000)
                if(a*a + b*b == c*c)
                    Console.WriteLine($"{a*b*c}");
